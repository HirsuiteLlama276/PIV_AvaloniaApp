using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Avalonia_App_PIV.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BorrowerButton(object? sender, RoutedEventArgs e)
    {
        var Add = new AddBorrowerWindow();
        Add.Show();
    }

    private void ShowListButton(object? sender, RoutedEventArgs e)
    {
        var Add = new ShowListWindow();
        Add.Show();
    }
    
    private void DeleteButton(object? sender, RoutedEventArgs e)
    {
        var Add = new DeleteButton();
        Add.Show();
    }
}