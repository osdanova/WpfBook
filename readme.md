# WPF Book
In this repository I'll store all of the knowledge, tools and other utilities that I use to make programs using WPF in .NET.

## App Setup
The entry point for WPF apps is App.xaml. This file contains the resources for your Application as well as the first Window that will open on startup (StartupUri)

## Content Containers
The content of the app can be located in containers:

- Window: The top most container. An WPF app has at least 1 window. Windows are independent from each other.
- User Control: User Controls can be placed inside Windows, Pages or other Controls.
- Page: Similar to User Controls, however they are use for navigation, the app can go back and forth between pages. Note that they remain in memory to do so.

## WPF

- [Panel Layouts](Book/WpfLayouts.md)
- [Controls](Book/WpfControls.md)
- [Data Controls](Book/WpfDataControls.md)
- [File Dialogs](Book/WpfFileDialogs.md)
- [Styling](Book/WpfStyling.md)
- [Resources](Book/WpfResources.md)
- [Navigation](Book/WpfNavigation.md)
- Binding
- [Converters](Book/WpfConverters.md)
- States (Maintaining static state vs passing state)
- Control communication (Events vs passing objects)

## C#

- [Coding Standards and Naming Conventions](Book/CsStandardsConventions.md)
- [Binary and Streams](Book/CsBinaryStreams.md)
- [Properties](Book/CsProperties.md)
- [Enums](Book/CsEnums.md)
- [Async](Book/CsAsync.md)

## .Net

- [Setup](Book/NetSetup.md)