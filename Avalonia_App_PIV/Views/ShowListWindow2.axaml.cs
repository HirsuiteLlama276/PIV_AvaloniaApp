using Avalonia;
using Avalonia_App_PIV.ViewModels;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;


namespace Avalonia_App_PIV.Views;

public partial class ShowListWindow2 : UserControl
{
    
    public ShowListWindow2()
    {
        InitializeComponent();
        DataContext = new ListWindowViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Return(object? sender, RoutedEventArgs e)
    {
        
        var windowReturns = new MainWindow();
        windowReturns.Show();

    }
}