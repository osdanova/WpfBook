# [WPF Book](../readme.md)

## Property Resources

## Resource Dictionaries
Files called Resource Dictionaries can be created. These files contain constants that can be used wherever the dictionary is imported.

    <ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
        <Brush x:Key="backgroundBrush">#DCE8F3</Brush>
        <Style x:Key="borderRedNoLine" TargetType="Border">
            <Setter Property="Background" Value="PaleVioletRed"/>
            <Setter Property="BorderThickness" Value="0"/>
        </Style>
    </ResourceDictionary>

To import a dictionary it is done like so:

    <Window.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="ResourceDictionary.xaml"/>
                <ResourceDictionary Source="AnotherDictionary.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Window.Resources>

The Source path starts at the project's root folder and the example is for Window but can be applied to other components.

## Static Resources
Data can be added as a Static Resource and then utilized in many places.

    <StackPanel Margin="10">
        <StackPanel.Resources>
            <sys:String x:Key="ComboBoxTitle">Items:</sys:String>
        </StackPanel.Resources>
        <Label Content="{StaticResource ComboBoxTitle}" />
    </StackPanel>

If a Static Resource is added in App.xaml it'll be accessible everywhere.

    <Application.Resources>
        <sys:String x:Key="ComboBoxTitle">Items:</sys:String>
    </Application.Resources>

## Directly Loading Files
Files can be loaded in the code-behind. Beware that the files' Property "BuildAction" must be set to "Resource".

    // Create Uri for the file
    Uri imageUri = new Uri(@"/Media/Image.png", UriKind.Relative);
    // Read image
    BitmapImage bmImage = new BitmapImage(imageUri);

    // Can also create a stream from it
    Uri soundUri = new Uri(@"/Media/Sounf.wav", UriKind.Relative);
    Stream soundStream = Application.GetResourceStream(soundUri).Stream;