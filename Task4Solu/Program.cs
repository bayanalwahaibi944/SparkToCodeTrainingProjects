namespace Task4Solu
{
    internal class Program
    {
        //Easy-task1 
        public static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
        }

        //Easy-task2 
        public static int Square(int number)
        {
            return number * number;
        }
        //Easy-task3 
        public static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        //Easy-task4
        public static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }
        //Medium-task5 
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        //Medium-task6 
        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        static void Main()
        {
            //Easy-task1 
            Console.Write("Enter your name: ");
            string task1Name = Console.ReadLine();

            PrintWelcome(task1Name);

            Console.WriteLine();
            //Easy-task2 

            Console.Write("Enter a number: ");
            int task2Num = Convert.ToInt32(Console.ReadLine());

            int sResult = Square(task2Num);

            Console.WriteLine("Square = " + sResult);
            //Easy-task3 
            Console.Write("Enter temperature in Celsius: ");
            double c= Convert.ToDouble(Console.ReadLine());

            double f = CelsiusToFahrenheit(c);

            Console.WriteLine("Temperature in Fahrenheit = " + f);

            //Easy-task4 
            DisplayMenu();
            //Medium-task5 
            Console.Write("Enter a number: ");
            int task5Num = int.Parse(Console.ReadLine());

            bool evenResult = IsEven(task5Num);

            if (evenResult == true)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            //Medium-task6 
            Console.Write("Enter rectangle length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rectangle width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);



        }
    }
}
