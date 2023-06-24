using System;

namespace Avalonia_App_PIV;

public class DebtorApp
{
    public class listDebtorApp
    {
        public Manager BorrowerManager { get; set; } = new Manager();
        public void AddBorrower()
        {
            var debtorName = "test";
            decimal debtorMoney = 1;
           // if (decimal.TryParse(debtorMoney, out decimal moneyInDecimal))
          //  { 
               // BorrowerManager.AddBorowers(debtorName, moneyInDecimal); 
                BorrowerManager.AddBorowers(debtorName, debtorMoney); 
           // }
          //  else
          // {
          //      Console.WriteLine("Podano złą kwotę - spróbuj jeszcze raz");
          //      AddBorrower();
           // }
            
        }

        public void DeleteBorrower()
        {
            Console.Clear();
            Console.WriteLine("Podaj nazwę dłużnika, którego chcesz usunąć z listy ");
            var debtorName = Console.ReadLine();
            BorrowerManager.DeleteBorowers(debtorName);
        }
        public void AllBorrowers()
        {
            Console.Clear();
            Console.WriteLine("Oto lista wszystkich dłużników: ");
            foreach(var borrower in BorrowerManager.ListBorrowers())
            {
                Console.WriteLine(borrower);
            }
            
          
        }
    }
}