namespace task5Solu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Easy-task1 
            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade: ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
            //Easy-task2 
            List<string> tasks = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter task: ");
                string task = Console.ReadLine();

                tasks.Add(task);
            }

            Console.WriteLine("To Do List:");

            foreach (string task in tasks)
            {
                Console.WriteLine("- " + task);
            }

        }
    }
}
