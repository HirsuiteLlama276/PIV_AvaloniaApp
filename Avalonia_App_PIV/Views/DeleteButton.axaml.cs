using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
namespace Avalonia_App_PIV.Views;
using Avalonia.Interactivity;

public partial class DeleteButton : Window
{
    public string UserName { get; set; }

    public decimal Money { get; set; }

    public DeleteButton()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        DataContext = this;
    }

    private void Delete(object? sender, RoutedEventArgs e)
    {
        Action saveAction = () =>
        {
            var mainApp = new DebtorApp.listDebtorApp();
            mainApp.DeleteBorrower(UserName);
        };
        saveAction.Invoke();
    }
}