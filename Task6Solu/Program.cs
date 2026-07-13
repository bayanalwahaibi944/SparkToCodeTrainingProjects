namespace Task6Solu
{
    internal class BankAccount
    {
        public int AccountNum { get; set; }

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
        internal class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }
}
