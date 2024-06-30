# [WPF Book](../readme.md)

## Converters
Converters allow to display a value as another value type. For example a list of number from 0 to 6 can be displayed as the strings Monday to Sunday.

A new class that implements IValueConverter is required. This interface requires the functions:

* Convert(Object, Type, Object, CultureInfo)
* ConvertBack(Object, Type, Object, CultureInfo)

Example code:

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is byte byteValue)
        {
            if (MyDictionary.TryGetValue(byteValue, out string stringValue))
            {
                return stringValue;
            }
        }
        return value.ToString();
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is string stringValue && parameter is Dictionary<byte, string> dictionary)
        {
            foreach (var kvp in MyDictionary)
            {
                if (kvp.Value == stringValue)
                {
                    return kvp.Key;
                }
            }
        }
        return value;
    }

## Combobox with converter
For the Combobox we additionaly need:

* A list from the Context that will be the list of options shown when opening the Combobox.
* Importing the converter as a static resource
* Make SURE to set RelativeSource correctly (Window, Page, UserControl)

Example code:

    <DataGrid.Resources>
        <local:MyConverter x:Key="MyConverter" />
    </DataGrid.Resources>

    <DataGridTemplateColumn Header="MyHeader">
        <DataGridTemplateColumn.CellTemplate>
            <DataTemplate>
                <TextBlock Text="{Binding MyVariable, Converter={StaticResource MyConverter}}" />
            </DataTemplate>
        </DataGridTemplateColumn.CellTemplate>
        <DataGridTemplateColumn.CellEditingTemplate>
            <DataTemplate>
                <ComboBox SelectedValue="{Binding MyVariable}"
                SelectedValuePath="Key"
                DisplayMemberPath="Value"
                ItemsSource="{Binding MyOptionsList, RelativeSource={RelativeSource AncestorType=UserControl}}" />
            </DataTemplate>
        </DataGridTemplateColumn.CellEditingTemplate>
    </DataGridTemplateColumn>