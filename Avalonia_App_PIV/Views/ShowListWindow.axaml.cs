using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia_App_PIV.ViewModels;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
namespace Avalonia_App_PIV.Views;
using Avalonia.Interactivity;

public partial class ShowListWindow : Window
{

    public ShowListWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        DataContext = new ListWindowViewModel();
    }
    
}