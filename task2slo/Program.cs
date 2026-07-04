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

            //medium-task5 
            int secNumber = 42;
            int guess;
            int attempts = 0;

            do
            {
                Console.Write("Guess the number: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess > secNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < secNumber)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Correct!");
                }

            } while (guess != secNumber);

            Console.WriteLine("Attempts: " + attempts);

            //medium-task6 
            try
            {
                Console.Write("Enter the first number: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int number2 = int.Parse(Console.ReadLine());

                int result = number1 / number2;

                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: You cannot divide by zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Please enter valid numbers.");
            }
            //medium-task7 

            int choice = 0;

            while (choice != 3)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1) Say Hello");
                Console.WriteLine("2) Show Current Time-of-day Greeting");
                Console.WriteLine("3) Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;

                        case 2:
                            Console.WriteLine("Good day! Hope you are having a great time.");
                            break;

                        case 3:
                            Console.WriteLine("Exiting program...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Please enter a numeric value.");
                }

                Console.WriteLine();
            }
            //Medium-task8 
            Console.Write("Enter a positive number N: ");
            int n1 = int.Parse(Console.ReadLine());

            int total1 = 0;

            for (int i = 1; i <= n1; i++)
            {
                if (i % 2 == 0)
                {
                    total = total + i;
                }
            }

            Console.WriteLine("Sum of even numbers = " + total1);


        }
    }
       
      
    
}
