using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_App_PIV.ViewModels;

public partial class ListWindowViewModel: ObservableObject
{
    public ObservableCollection<string> Borrowers { get; }
    
    public ListWindowViewModel()
    {
        Borrowers = new ObservableCollection<string>();
        Borrowers = DebtorApp.listDebtorApp.AllBorrowers();
    }
}