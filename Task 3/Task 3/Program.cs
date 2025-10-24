using System;
using System.Globalization;
using System.Text;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            CultureInfo.CurrentCulture = new CultureInfo("uk-UA");

            CurrentAccount currentAcc = new CurrentAccount("Іван Петренко", 5000.00, "UA-CURR-001");
            currentAcc.DisplayInfo();

            
            currentAcc.Top_up_account(1500.50);
            currentAcc.Withdraw_from_account(3000.00);
            currentAcc.Withdraw_from_account(10000.00);
            currentAcc.DisplayInfo();
            DepositAccount depositAcc = new DepositAccount("Марія Сидоренко", 20000.00, "UA-DEP-002");
            depositAcc.DisplayInfo();

            depositAcc.Top_up_account(5000.00);
            depositAcc.Withdraw_from_account(10000.00);
            depositAcc.Withdraw_from_account(50000.00);
            depositAcc.DisplayInfo();
            currentAcc.Delete_account();
            currentAcc.Top_up_account(100.00); 
            currentAcc.DisplayInfo();

            depositAcc.Delete_account();
            depositAcc.DisplayInfo();

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
