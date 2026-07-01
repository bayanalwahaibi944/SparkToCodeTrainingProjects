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

            //Easy-task 3 

            Console.WriteLine("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even ");
            }
            else
            {
                Console.WriteLine("The number is odd ");
            }
            //Easy-task 4  
            Console.WriteLine("Enter your age: ");
            int age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you have a valid national ID? yes/no ");
            string id = Console.ReadLine();
            bool hasid = id == "yes";
            if (age1 >= 18 && hasid)
            {
                Console.WriteLine("Eligible to vote");
            }else
            {
                Console.WriteLine("Not eligible to vote");
            }

            //Easy-task 5 

            Console.Write("Enter grade letter A, B, C, D, or F: ");
            char grade = char.Parse(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }

            //Medium-task6 

            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            if (celsius < 10)
            {
                Console.WriteLine("Cold");
            }
            else if (celsius <= 30)
            {
                Console.WriteLine("Mild");
            }
            else
            {
                Console.WriteLine("Hot");
            }

            //Medium-task7

            Console.Write("Enter your age: ");
            int age2 = int.Parse(Console.ReadLine());
            if (age2 >= 0 && age <= 12)
            {
                Console.WriteLine("Category: Child");
                Console.WriteLine("Price:2.000 OMR");
            }
            else if (age2 >= 13 && age2 <= 59)
            {
                Console.WriteLine("Category: Adult");
                Console.WriteLine("Price:5.000 OMR");
            }
            else if (age2 >= 60)
            {
                Console.WriteLine("Category: Senior");
                Console.WriteLine("Price:3.000 OMR");
            }
            else
            {
                Console.WriteLine("Invalid age");
            }
            //Medium-task8 

            Console.Write("Enter total bill amount: ");
            double bill = double.Parse(Console.ReadLine());

            Console.Write("Are you a loyalty member? yes/no: ");
            string member = Console.ReadLine();
            bool isMember = member == "yes";

            double discount = 0;

            if (bill > 20 && isMember)
            {
                discount = bill * 0.15;
            }

            double finalAmount = bill - discount;

            Console.WriteLine("Original Bill: ", bill);
            Console.WriteLine("Discount Amount: ", discount);
            Console.WriteLine("Final Amount:  ", finalAmount);


        }
    }
}
