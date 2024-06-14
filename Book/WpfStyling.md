# [WPF Book](../readme.md)

## Styles
Styles for controls can be created and reutilized in as many controls as needed. If no Key is set it'll apply to all components.

    <Style TargetType="Button" x:Key="SampleButtonStyle">
        <Setter Property="Width" Value="50" />
        <Setter Property="FontSize" Value="15" />
    </Style>
    ----------------------------------------------------------------------
    <Button Style="{StaticResource SampleButtonStyle}" />

## ControlTemplate

## Scrolling (ScrollViewer)