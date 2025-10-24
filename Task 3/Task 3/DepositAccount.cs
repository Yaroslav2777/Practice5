using System;
using System.Globalization;

namespace Task_3
{
    internal class DepositAccount : BankAccount
    {
        private CultureInfo culture = new CultureInfo("uk-UA");


        public DepositAccount(string ownerName, double initialBalance, string accountNumber)
            : base()
        {
            base.New_account(ownerName, initialBalance, accountNumber);
        }
        public override void Top_up_account(double amount)
        {
            if (!IsActive)
            {
                Console.WriteLine($"[Рахунок {AccountNumber}] Рахунок неактивний. Поповнення неможливе.");
                return;
            }
            if (amount <= 0)
            {
                Console.WriteLine($"[Рахунок {AccountNumber}] Сума поповнення має бути позитивною.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"[Рахунок {AccountNumber}] Депозит поповнено на {amount.ToString("C", culture)}. Новий баланс: {Balance.ToString("C", culture)}");
        }


        public override void Withdraw_from_account(double amount)
        {
            if (!IsActive)
            {
                Console.WriteLine($"[Рахунок {AccountNumber}] Рахунок неактивний. Зняття неможливе.");
                return;
            }
            if (amount <= 0)
            {
                Console.WriteLine($"[Рахунок {AccountNumber}] Сума зняття має бути позитивною.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine($"[Рахунок {AccountNumber}] Недостатньо коштів на депозиті. Баланс: {Balance.ToString("C", culture)}, Запит: {amount.ToString("C", culture)}");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"[Рахунок {AccountNumber}] Знято з депозиту {amount.ToString("C", culture)}. Новий баланс: {Balance.ToString("C", culture)}");
            }
        }


        public override void DisplayInfo()
        {
            Console.WriteLine("--- Депозитний Рахунок ---");
            base.DisplayInfo();
        }
    }
}
