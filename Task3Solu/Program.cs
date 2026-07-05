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
        }
    }
}
