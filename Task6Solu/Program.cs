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
        internal class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }
}
