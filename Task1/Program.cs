namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Easy-task 1
            string name = "Bayan";
            int age = 23;
            double height = 154;
            bool student = true;

            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Height : " + height);
            Console.WriteLine("Student : " + student);

            //Easy-task 2 

            Console.WriteLine("Enter rectangle length : ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter rectangle width : ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length +  width);

            Console.WriteLine("Area : " + area);
            Console.WriteLine("Perimeter : " + perimeter);








        }
    }
}
