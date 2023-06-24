using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
namespace Avalonia_App_PIV.Views;

public partial class ShowListWindow : Window
{
    public ShowListWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}