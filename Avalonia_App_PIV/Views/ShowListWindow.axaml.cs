using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
namespace Avalonia_App_PIV.Views;
using Avalonia.Interactivity;

public partial class ShowListWindow : Window
{
    public List<string> _Borrowers { get; set; }
    
    public ShowListWindow()
    {
        var mainApp = new DebtorApp.listDebtorApp();
        _Borrowers = mainApp.AllBorrowers();
        InitializeComponent();

    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        DataContext = this;
    }
    
}