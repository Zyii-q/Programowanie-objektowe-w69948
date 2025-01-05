using System;
using System.Collections.Generic;
using System.Globalization;

namespace BankSystem
{
    public class Account
    {
        private static readonly CultureInfo PolishCulture = new CultureInfo("pl-PL");

        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public List<string> TransactionHistory { get; private set; }

        public Account(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            TransactionHistory = new List<string>();
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            TransactionHistory.Add($"Wpłata: +{amount.ToString("C", PolishCulture)} | Saldo: {Balance.ToString("C", PolishCulture)}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Operacja niemożliwa: Brak wystarczających środków.");
                return;
            }
            Balance -= amount;
            TransactionHistory.Add($"Wypłata: -{amount.ToString("C", PolishCulture)} | Saldo: {Balance.ToString("C", PolishCulture)}");
        }

        public void ShowHistory()
        {
            if (TransactionHistory.Count == 0)
            {
                Console.WriteLine("Brak historii transakcji.");
            }
            else
            {
                Console.WriteLine("Historia transakcji:");
                foreach (var entry in TransactionHistory)
                {
                    Console.WriteLine(entry);
                }
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Numer konta: {AccountNumber}, Saldo: {Balance.ToString("C", PolishCulture)}");
        }
    }
}
