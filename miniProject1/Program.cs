using System;
using System.Collections.Generic;
namespace BankingSystemApp
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. <your 2nd custom service - choose a name>");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                    
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        ListAllAccounts();
                        break;
                    case 7:
                        // TODO: call your second custom service function here
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter account number: ");
            string accountNum = Console.ReadLine();
            if (accountNumbers.Contains(accountNum))
            {
                Console.WriteLine("This account number already exists");
                return;
            }
            Console.WriteLine("Enter initial deposit amount  ");
            double initialDep;
            try
            {
                initialDep = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount");
                return;
            }
            if (initialDep < 0)
            {
                Console.WriteLine("Initial deposit cannot be negative");
                return;
            }
            customerNames.Add(name);
            accountNumbers.Add(accountNum);
            balances.Add(initialDep);
            Console.WriteLine("Customer name: " + name);
            Console.WriteLine("Account number: " + accountNum);
            Console.WriteLine("Balance: " + initialDep);

        }
        static void DepositMoney()
        {
            Console.Write("Enter account number: ");
            string accountNum = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNum);
            if (index == -1) {
                Console.WriteLine("Account not found");
                return;

            }
            Console.Write("Enter deposit amount: ");

            double amount;
            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception) {
                Console.WriteLine("Invalid amount");
                return;
            }
            if (amount <= 0) {
                Console.WriteLine("Deposit amount must be positive");
                return;
            }
            balances[index] = balances[index] + amount;
            Console.WriteLine("Updated balance:" + balances[index]);



        }
        static void WithdrawMoney()
        {
            Console.Write("Enter account number: ");
            string accountNum = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNum);

            if (index == -1)
            {
                Console.WriteLine("Account not found");
                return;
            }

            Console.Write("Enter withdrawal amount: ");

            double amount;

            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive");
                return;
            }

            if (amount > balances[index])
            {
                Console.WriteLine("Insufficient balance");
                return;
            }
            balances[index] = balances[index] - amount;
            Console.WriteLine("Updated balance: " + balances[index]);
        }
        static void ShowBalance()
        {
            Console.Write("Enter account number: ");
            string accountNum = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNum);

            if (index == -1)
            {
                Console.WriteLine("Account not found");
                return;
            }

            Console.WriteLine("Customer name: " + customerNames[index]);
            Console.WriteLine("Account number: " + accountNumbers[index]);
            Console.WriteLine("Current balance: " + balances[index]);
        
        }
        static void TransferAmount()
        {
            Console.Write("Enter sender account number: ");
            string senderAccNum = Console.ReadLine();

            int senderIndex = accountNumbers.IndexOf(senderAccNum);

            if (senderIndex == -1)
            {
                Console.WriteLine("Sender account not found");
                return;
            }

            Console.Write("Enter receiver account number: ");
            string receiverAccNum = Console.ReadLine();

            int receiverIndex = accountNumbers.IndexOf(receiverAccNum);

            if (receiverIndex == -1)
            {
                Console.WriteLine("Receiver account not found");
                return;
            }
            if (senderIndex == receiverIndex)
            {
                Console.WriteLine("You cannot transfer to the same account");
                return;
            }

            Console.Write("Enter transfer amount: ");

            double amount;

            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Transfer amount must be positive");
                return;
            }

            if (amount > balances[senderIndex])
            {
                Console.WriteLine("Insufficient balance");
                return;
            }

            balances[senderIndex] = balances[senderIndex] - amount;
            balances[receiverIndex] = balances[receiverIndex] + amount;

            Console.WriteLine("Sender updated balance: " + balances[senderIndex]);
            Console.WriteLine("Receiver updated balance: " + balances[receiverIndex]);

        }
        static void ListAllAccounts()
        {
            if (accountNumbers.Count == 0)
            {
                Console.WriteLine("No accounts found");
                return;
            }

            for (int i = 0; i < accountNumbers.Count; i++)
            {
                Console.WriteLine("Customer name: " + customerNames[i]);
                Console.WriteLine("Account number: " + accountNumbers[i]);
                Console.WriteLine("Balance: " + balances[i]);
               
            }

        }
        // TODO: write two more void, no-parameter functions here for
        // your own custom services (option 6 and option 7)
    }
}