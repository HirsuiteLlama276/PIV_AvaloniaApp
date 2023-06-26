using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
namespace Avalonia_App_PIV.Views;

public partial class AddBorrowerWindow : Window
{
    public string UserName { get; set; }
    
    public decimal Money { get; set; }
    

    public AddBorrowerWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        DataContext = this;
    }

    private void Save(object? sender, RoutedEventArgs e)
    {
        Action saveAction = () =>
        {
            var mainApp = new DebtorApp.listDebtorApp();
            mainApp.AddBorrower(UserName,Money);
        };
        saveAction.Invoke();
    }
}