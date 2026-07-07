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
        }
    }
}
