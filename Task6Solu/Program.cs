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
            Console.WriteLine("Email notification sent.");
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
                Console.WriteLine("Registration email sent.");
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

        internal class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }
}
