using System;
using System.Collections.Generic;
using System.Globalization;

namespace BankSystem
{
    public class BankSystem
    {
        private List<User> users = new List<User>();
        private Dictionary<string, Account> accounts = new Dictionary<string, Account>();
        private Random random = new Random();

        public void RegisterUser(string login, string password, string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(login)) throw new ArgumentException("Login nie może być pusty.");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Hasło nie może być puste.");
            if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("Imię nie może być puste.");
            if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("Nazwisko nie może być puste.");

            if (users.Exists(u => u.Login == login))
            {
                throw new InvalidOperationException("Login jest zajęty.");
            }

            var user = new User(login, password, firstName, lastName);
            users.Add(user);

            var accountNumber = GenerateAccountNumber();
            var account = new Account(accountNumber, 0);
            accounts[user.Login] = account;

            Console.WriteLine($"Rejestracja zakończona sukcesem! Numer konta: {accountNumber}, Saldo: {account.Balance.ToString("C", new CultureInfo("pl-PL"))}");
        }

        public User AuthenticateUser(string login, string password)
        {
            var user = users.Find(u => u.Login == login);
            if (user == null || !user.CheckPassword(password))
            {
                throw new UnauthorizedAccessException("Nieprawidłowe dane logowania.");
            }
            return user;
        }

        public Account GetAccount(string login)
        {
            if (accounts.TryGetValue(login, out var account))
            {
                return account;
            }
            throw new KeyNotFoundException("Konto nie zostało znalezione.");
        }

        private string GenerateAccountNumber()
        {
            return random.Next(10000000, 99999999).ToString();
        }
    }
}
