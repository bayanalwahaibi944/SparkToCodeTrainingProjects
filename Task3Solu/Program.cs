namespace Task3Solu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Easy-task1 
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double difference = Math.Abs(num1 - num2);

            Console.WriteLine("Positive difference: " + difference);
            //Easy-task2 
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());

            double s = Math.Pow(number, 2);
            double sR = Math.Sqrt(number);

            Console.WriteLine("Square: " + s);
            Console.WriteLine("Square root: " + sR);
            //Easy-task3
            Console.Write("Enter your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Uppercase: " + name.ToUpper());
            Console.WriteLine("Lowercase: " + name.ToLower());
            Console.WriteLine("Number of characters: " + name.Length);
            //Easy-task4
            Console.Write("Enter number of free trial days: ");
            int days = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime endDate = today.AddDays(days);

            Console.WriteLine("Trial end date: " + endDate.ToString("yyyy-MM-dd"));
            //Medium-task5 
            Console.Write("Enter raw exam score: ");
            double score = double.Parse(Console.ReadLine());

            double roundedScore = Math.Round(score, 0);

            Console.WriteLine("Rounded score: " + roundedScore);

            if (roundedScore >= 60)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }
            //Medium-task6 
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            string lowerPassword = password.ToLower();

            if (password.Length >= 8 && !lowerPassword.Contains("password"))
            {
                Console.WriteLine("Strong");
            }
            else
            {
                Console.WriteLine("Weak");

                if (password.Length < 8)
                {
                    Console.WriteLine("Reason: Password must be at least 8 characters.");
                }

                if (lowerPassword.Contains("password"))
                {
                    Console.WriteLine("Reason: Password must not contain the word password.");
                }
            }
            //Medium-task7 
            Console.Write("Enter name first time: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter name second time: ");
            string name2 = Console.ReadLine();

            string cleanName1 = name1.Trim().ToUpper();
            string cleanName2 = name2.Trim().ToUpper();

            if (cleanName1 == cleanName2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }


        }
    }
}
