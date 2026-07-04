namespace task2slo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //easy-task1 
            Console.Write("Enter a number: ");
            int start = int.Parse(Console.ReadLine());

            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Liftoff!");
            
            //easy-task2 
            Console.Write("Enter a positive number N: ");
            int n = int.Parse(Console.ReadLine());

            int total = 0;

            for (int i = 1; i <= n; i++)
            {
                total = total + i;
            }

            Console.WriteLine("Sum = " + total);

            //easy-task3 
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " x " + i + " = " + (number * i));
            }
            //easy-task4 
            string correctPW = "Spark2026";

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            while (password != correctPW)
            {
                Console.WriteLine("Incorrect password, try again");
                Console.Write("Enter password: ");
                password = Console.ReadLine();
            }

            Console.WriteLine("Access Granted");
        }
    }
       
      
    
}
