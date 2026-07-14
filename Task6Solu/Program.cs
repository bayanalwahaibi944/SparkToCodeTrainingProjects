namespace Task6Solu
{
    //BankAccount Class 
    internal class BankAccount
    {
        public int AccountNumber { get; set; }

        public string HolderName { get; set; }

        public double Balance { get; set; }


        public void Deposit(double amount)
        {
            Balance = Balance + amount;

            SendEmail();
        }


        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance = Balance - amount;

                SendEmail();
            }
        }


        public double CheckBalance()
        {
            PrintInformation();

            return Balance;
        }


        private void PrintInformation()
        {
            Console.WriteLine($"Holder Name: {HolderName}");

            Console.WriteLine($"Balance: {Balance}");
        }


        private void SendEmail()
        {
            Console.WriteLine("Email notification sent ");
        }
    }
        //Student Class 
        internal class Student
        {
            public int Grade { get; set; }

            public string Name { get; set; }

            public string Address { get; set; }


            private string email;


            int age;


            public void Register(string Email)
            {
                email = Email;

                SendEmail();
            }


            private void SendEmail()
            {
                Console.WriteLine("Registration email sent ");
            }
        }
        //Product Class 
        internal class Product
        {
            public string ProductName { get; set; }

            public double Price { get; set; }

            public int StockQuantity { get; set; }


            public void Sell(int quantity)
            {
                if (StockQuantity >= quantity)
                {
                    StockQuantity = StockQuantity - quantity;
                }
                else
                {
                    Console.WriteLine("Not enough stock.");
                }

                LogTransaction();
            }


            public void Restock(int quantity)
            {
                StockQuantity = StockQuantity + quantity;

                LogTransaction();
            }


            public double GetInventoryValue()
            {
                PrintDetails();

                return Price * StockQuantity;
            }


            private void PrintDetails()
            {
                Console.WriteLine($"Product Name: {ProductName}");

                Console.WriteLine($"Price: {Price}");

                Console.WriteLine($"Stock Quantity: {StockQuantity}");
            }


            private void LogTransaction()
            {
                Console.WriteLine("Transaction logged.");
            }
        }
    internal class Program
    {
        //Two Accounts 
        static BankAccount account1 = new BankAccount
        {
            AccountNumber = 1163,
            HolderName = "karim",
            Balance = 120
        };


        static BankAccount account2 = new BankAccount
        {
            AccountNumber = 15203,
            HolderName = "Ali",
            Balance = 63
        };
        //Two Students 
        static Student student1 = new Student
        {
            Name = "Ali",
            Address = "Muscat",
            Grade = 65
        };

        static Student student2 = new Student
        {
            Name = "Ahmed",
            Address = "Muscat",
            Grade = 70
        };
        //                                                
        static Product product1 = new Product
        {
            ProductName = "Wireless Mouse",
            Price = 5.500,
            StockQuantity = 50
        };


        static Product product2 = new Product
        {
            ProductName = "Mechanical Keyboard",
            Price = 15.750,
            StockQuantity = 20
        };
        //Easy-Task1 
        static BankAccount SelectAccount()
        {
            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");

            Console.Write("Choose an account: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                return account1;
            }
            else
            {
                return account2;
            }
        }
        static void Case1ViewAccountDetails()
        {
            BankAccount selectedAccount = SelectAccount();

            selectedAccount.CheckBalance();
        }
        //
       
            static void Main(string[] args)
            {
                bool exitProgram = false;

                while (!exitProgram)
                {
                   

                    Console.WriteLine("1. View Account Details");
                    Console.WriteLine("2. Update Student Address");
                    Console.WriteLine("3. Make a Deposit");
                    Console.WriteLine("4. Make a Withdrawal");
                    Console.WriteLine("5. View Product Details");
                    Console.WriteLine("6. Register a Student");
                    Console.WriteLine("7. Compare Two Account Balances");
                    Console.WriteLine("8. Restock Product and Check Stock Level");
                    Console.WriteLine("9. Transfer Between Accounts");
                    Console.WriteLine("10. Update Student Grade");
                    Console.WriteLine("11. Student Report Card");
                    Console.WriteLine("12. Account Health Status");
                    Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                    Console.WriteLine("14. Scholarship Eligibility Check");
                    Console.WriteLine("15. Full Balance Top-Up Flow");
                    Console.WriteLine("16. Quick Account Opening");
                    Console.WriteLine("17. Total Students Counter");
                    Console.WriteLine("18. Overdrawn Account Check");
                    Console.WriteLine("19. Set Student Security PIN");
                    Console.WriteLine("20. Exit");

                    Console.Write("Choose an option: ");

                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int choice))
                    {
                        Console.WriteLine("Invalid menu choice.");

                        continue;
                    }

                    switch (choice)
                    {
                        //Easy-Task1
                        case 1:
                            Case1ViewAccountDetails();
                            break;
                        case 20:
                            exitProgram = true;

                            Console.WriteLine("Program closed");

                            break;

                        default:
                            Console.WriteLine(
                                "This case has not been added yet");

                            break;
                    }
                }
            }
        }
    }

    

