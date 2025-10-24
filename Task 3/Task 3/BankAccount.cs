using System;
using System.Globalization;

namespace Task_3
{

    internal abstract class BankAccount : IAccountService
    {
        public string AccountNumber { get; protected set; }
        public string OwnerName { get; protected set; }
        public double Balance { get; protected set; }
        public bool IsActive { get; protected set; }

        public BankAccount()
        {
            Balance = 0;
            IsActive = false;
        }

        public void New_account(string ownerName, double initialBalance, string accountNumber)
        {
            OwnerName = ownerName;
            Balance = initialBalance;
            AccountNumber = accountNumber;
            IsActive = true;
            Console.WriteLine($"[Рахунок {AccountNumber}] Новий рахунок успішно відкрито для {OwnerName} з балансом {Balance.ToString("C", new CultureInfo("uk-UA"))}.");
        }
        public void Delete_account()
        {
            if (IsActive)
            {
                IsActive = false;
                double remainingBalance = Balance;
                Balance = 0;
                Console.WriteLine($"[Рахунок {AccountNumber}] Рахунок для {OwnerName} закрито. Залишок {remainingBalance.ToString("C", new CultureInfo("uk-UA"))} анульовано (або переказано).");
            }
            else
            {
                Console.WriteLine($"[Рахунок {AccountNumber}] Рахунок вже неактивний.");
            }
        }

        public abstract void Top_up_account(double amount);

        public abstract void Withdraw_from_account(double amount);

        public virtual void DisplayInfo()
        {
            string status = IsActive ? "Активний" : "Закритий";
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Номер рахунку: {AccountNumber}");
            Console.WriteLine($"Власник: {OwnerName}");
            Console.WriteLine($"Баланс: {Balance.ToString("C", new CultureInfo("uk-UA"))}");
            Console.WriteLine($"Статус: {status}");
            Console.WriteLine("------------------------------------");
        }
    }
}
