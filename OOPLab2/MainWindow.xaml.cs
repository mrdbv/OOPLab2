using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

< Window x: Class = "OOPLab2.MainWindow"
        xmlns = "http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns: x = "http://schemas.microsoft.com/winfx/2006/xaml"
        Title = "Лабораторна робота №2"
        Height = "420"
        Width = "500"
        WindowStartupLocation = "CenterScreen" >

    < Grid Margin = "25" >
        < Grid.RowDefinitions >
            < RowDefinition Height = "Auto" />
            < RowDefinition Height = "Auto" />
            < RowDefinition Height = "Auto" />
            < RowDefinition Height = "Auto" />
            < RowDefinition Height = "Auto" />
            < RowDefinition Height = "Auto" />
        </ Grid.RowDefinitions >

        < Grid.ColumnDefinitions >
            < ColumnDefinition Width = "Auto" />
            < ColumnDefinition Width = "*" />
        </ Grid.ColumnDefinitions >

        < TextBlock Grid.Row = "0"
                   Grid.ColumnSpan = "2"
                   Text = "Обчислення значення s"
                   FontSize = "22"
                   FontWeight = "Bold"
                   HorizontalAlignment = "Center"
                   Margin = "0,0,0,20" />

        < TextBlock Grid.Row = "1"
                   Text = "Введіть x:"
                   Margin = "0,5" />

        < TextBox x: Name = "XTextBox"
                 Grid.Row = "1"
                 Grid.Column = "1"
                 Margin = "15,5,0,5" />

        < TextBlock Grid.Row = "2"
                   Text = "Введіть y:"
                   Margin = "0,5" />

        < TextBox x: Name = "YTextBox"
                 Grid.Row = "2"
                 Grid.Column = "1"
                 Margin = "15,5,0,5" />

        < TextBlock Grid.Row = "3"
                   Text = "Введіть z:"
                   Margin = "0,5" />

        < TextBox x: Name = "ZTextBox"
                 Grid.Row = "3"
                 Grid.Column = "1"
                 Margin = "15,5,0,5" />

        < StackPanel Grid.Row = "4"
                    Grid.ColumnSpan = "2"
                    Orientation = "Horizontal"
                    HorizontalAlignment = "Center"
                    Margin = "0,20,0,10" >

            < Button Content = "Обчислити"
                    Width = "120"
                    Height = "35"
                    Margin = "5"
                    Click = "CalculateButton_Click" />

            < Button Content = "Очистити"
                    Width = "120"
                    Height = "35"
                    Margin = "5"
                    Click = "ClearButton_Click" />
        </ StackPanel >

        < TextBlock x: Name = "ResultTextBlock"
                   Grid.Row = "5"
                   Grid.ColumnSpan = "2"
                   FontSize = "17"
                   FontWeight = "SemiBold"
                   TextWrapping = "Wrap"
                   HorizontalAlignment = "Center"
                   Margin = "0,15,0,0" />
    </ Grid >
</ Window >