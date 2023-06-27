using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Media;
using ReactiveUI;
using System.Windows;

namespace Avalonia_App_PIV;

public class DebtorApp
{
    public class listDebtorApp
    {
        public static Manager BorrowerManager { get; set; } = new Manager();
        public void AddBorrower(string debtorName, decimal debtorMoney)
        {
            BorrowerManager.AddBorowers(debtorName, debtorMoney);
        }

        public void DeleteBorrower(string debtorName)
        {
            BorrowerManager.DeleteBorowers(debtorName);
        }
        public static ObservableCollection<string>  AllBorrowers()
        {
            /*
            foreach(var borrower in BorrowerManager.ListBorrowers())
            {
                Console.WriteLine(borrower);
            }
            */
            var borrower = BorrowerManager.ListBorrowers();
            return borrower;
        }
    }
}