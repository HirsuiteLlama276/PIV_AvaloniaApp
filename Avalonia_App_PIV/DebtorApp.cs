using System;

namespace Avalonia_App_PIV;

public class DebtorApp
{
    public class listDebtorApp
    {
        public Manager BorrowerManager { get; set; } = new Manager();
        public void AddBorrower(string debtorName, decimal debtorMoney)
        {
            BorrowerManager.AddBorowers(debtorName, debtorMoney);
        }

        public void DeleteBorrower(string debtorName)
        {
            BorrowerManager.DeleteBorowers(debtorName);
        }
        public void AllBorrowers()
        {
            foreach(var borrower in BorrowerManager.ListBorrowers())
            {
                Console.WriteLine(borrower);
            }
            
          
        }
    }
}