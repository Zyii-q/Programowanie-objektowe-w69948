using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankSystem = new BankSystem();
            Console.WriteLine("=== Witamy w systemie bankowym ===");

            while (true)
            {
                Console.WriteLine("\nWybierz opcję:");
                Console.WriteLine("1. Rejestracja");
                Console.WriteLine("2. Logowanie");
                Console.WriteLine("3. Wyjście");
                Console.Write("Twój wybór: ");
                string option = Console.ReadLine();

                try
                {
                    switch (option)
                    {
                        case "1":
                            RegisterAndLoginUser(bankSystem);
                            break;

                        case "2":
                            AuthenticateUser(bankSystem);
                            break;

                        case "3":
                            Console.WriteLine("Do zobaczenia!");
                            return;

                        default:
                            Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }
        }

        static void RegisterAndLoginUser(BankSystem bankSystem)
        {
            Console.WriteLine("\n=== Rejestracja użytkownika ===");

            Console.Write("Wprowadź login: ");
            string login = Console.ReadLine();

            Console.Write("Wprowadź hasło: ");
            string password = Console.ReadLine();

            Console.Write("Wprowadź imię: ");
            string firstName = Console.ReadLine();

            Console.Write("Wprowadź nazwisko: ");
            string lastName = Console.ReadLine();

            bankSystem.RegisterUser(login, password, firstName, lastName);

            // Видаляємо зайвий текст з балансом
            Console.WriteLine("\nRejestracja zakończona sukcesem!Automatyczne logowanie.\n");
          

            AuthenticateAfterRegistration(bankSystem, login);
        }

        static void AuthenticateAfterRegistration(BankSystem bankSystem, string login)
        {
            var account = bankSystem.GetAccount(login);

            while (true)
            {
                ShowMainScreen(account);

                Console.WriteLine("\nWybierz działanie:");
                Console.WriteLine("1. Wpłata");
                Console.WriteLine("2. Wypłata");
                Console.WriteLine("3. Pokaż historię transakcji");
                Console.WriteLine("4. Wylogowanie");
                Console.Write("Twój wybór: ");
                string action = Console.ReadLine();

                try
                {
                    switch (action)
                    {
                        case "1":
                            Console.Write("Podaj kwotę do wpłaty: ");
                            decimal depositAmount = decimal.Parse(Console.ReadLine());
                            account.Deposit(depositAmount);
                            Console.WriteLine("Wpłata zakończona sukcesem.");
                            break;

                        case "2":
                            Console.Write("Podaj kwotę do wypłaty: ");
                            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                            account.Withdraw(withdrawAmount);
                            Console.WriteLine("Wypłata zakończona sukcesem.");
                            break;

                        case "3":
                            Console.WriteLine("\nHistoria transakcji:");
                            account.ShowHistory();
                            break;

                        case "4":
                            Console.WriteLine("Wylogowano.");
                            return;

                        default:
                            Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }
        }

        static void AuthenticateUser(BankSystem bankSystem)
        {
            Console.WriteLine("\n=== Logowanie ===");

            Console.Write("Wprowadź login: ");
            string login = Console.ReadLine();

            Console.Write("Wprowadź hasło: ");
            string password = Console.ReadLine();

            var user = bankSystem.AuthenticateUser(login, password);
            var account = bankSystem.GetAccount(user.Login);

            while (true)
            {
                ShowMainScreen(account);

                Console.WriteLine("\nWybierz działanie:");
                Console.WriteLine("1. Wpłata");
                Console.WriteLine("2. Wypłata");
                Console.WriteLine("3. Pokaż historię transakcji");
                Console.WriteLine("4. Wylogowanie");
                Console.Write("Twój wybór: ");
                string action = Console.ReadLine();

                try
                {
                    switch (action)
                    {
                        case "1":
                            Console.Write("Podaj kwotę do wpłaty: ");
                            decimal depositAmount = decimal.Parse(Console.ReadLine());
                            account.Deposit(depositAmount);
                            Console.WriteLine("Wpłata zakończona sukcesem.");
                            break;

                        case "2":
                            Console.Write("Podaj kwotę do wypłaty: ");
                            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                            account.Withdraw(withdrawAmount);
                            Console.WriteLine("Wypłata zakończona sukcesem.");
                            break;

                        case "3":
                            Console.WriteLine("\nHistoria transakcji:");
                            account.ShowHistory();
                            break;

                        case "4":
                            Console.WriteLine("Wylogowano.");
                            return;

                        default:
                            Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }
        }

        static void ShowMainScreen(Account account)
        {
            Console.WriteLine($"\n=== Twoje konto ===");
            Console.WriteLine($"Numer konta: {account.AccountNumber}");
            Console.WriteLine($"Saldo: {account.Balance.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("pl-PL"))}");
        }
    }
}
