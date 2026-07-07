namespace Task4Solu
{
    internal class Program
    {
        //Easy-task1 
        public static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
        }

        static void Main()
        {
            //Easy-task1 
            Console.Write("Enter your name: ");
            string task1Name = Console.ReadLine();

            PrintWelcome(task1Name);

            Console.WriteLine();
        }
    }
}
