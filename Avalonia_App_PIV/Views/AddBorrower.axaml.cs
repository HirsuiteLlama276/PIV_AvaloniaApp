using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
namespace Avalonia_App_PIV.Views;

public partial class AddBorrowerWindow : Window
{

    private decimal _money;
    private string _name;

    
    public decimal Money
    {
        get { return _money; }
        set
        {
            if (_money != value)
            {
                _money = value;
            }
        }
    }
    public string Name
    {
        get { return _name; }
        set
        {
            if (_name != value)
            {
                _name = value;
            }
        }
    }

    public AddBorrowerWindow()
    {

        InitializeComponent();
        DataContext = new AddBorrowerWindow();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
  
    }

    private void Save(object? sender, RoutedEventArgs e)
    {

        var mainApp = new DebtorApp.listDebtorApp();
        mainApp.AddBorrower(_name,_money);
    }
}