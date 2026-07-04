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

        }
    }
       
      
    
}
