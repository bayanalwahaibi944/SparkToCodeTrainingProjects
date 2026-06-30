namespace CsharpSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name: ");
            string userName = Console.ReadLine();

            Console.Write("Please Enter Your Age: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Salary: ");
            float userSalary = float.Parse(Console.ReadLine());
            //Calculator Operators
            Console.Write("Enter first number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            float additionResult = firstNumber + secondNumber;
            float subtractionResult = firstNumber - secondNumber;
            float multiplicationResult = firstNumber * secondNumber;
            float divisionResult = firstNumber / secondNumber;
            float reminderResult = firstNumber % secondNumber;

            bool comparisonResult = firstNumber == secondNumber;
            bool testResult = !(10 > 5);

            Console.WriteLine("Addition result: " + additionResult);
            Console.WriteLine("Subtraction result: " + subtractionResult);
            Console.WriteLine("Multiplication result: " + multiplicationResult);
            Console.WriteLine("Division result: " + divisionResult);
            Console.WriteLine("Reminder result: " + reminderResult);
            Console.WriteLine("Comparison result: " + comparisonResult);
            Console.WriteLine("Test result: " + testResult);
            /* and: &&
             * Or: || 
             * not: ! */

            //if statement 

            Console.WriteLine("Enter your degree: ");
            float degree = float.Parse(Console.ReadLine());

            if (degree >= 0 && degree < 50)
            {
                Console.WriteLine("You failed");
            }
            else if (degree >= 50 && degree < 60)
            {
                Console.WriteLine("You passed with Grade: D");
            }
            else if (degree >= 60 && degree < 70)
            {
                Console.WriteLine("You passed with Grade: C");
            }
            else if (degree >= 70 && degree < 80)
            {
                Console.WriteLine("You passed with Grade: B");
            }
            else if (degree >= 80 && degree <= 100)
            {
                Console.WriteLine("You passed with Grade: A");
            }
            else
            {
                Console.WriteLine("You entered a wrong number");
            }
            //Switch-case Statement 

            Console.WriteLine("Welcome to Bank menu:");
            Console.WriteLine("1. Deposite");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance check");

            Console.WriteLine("Please choose an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Deposited");
                    break;

                case 2:
                    Console.WriteLine("Withdrawed");
                    break;

                case 3:
                    Console.WriteLine("Your balance = ");
                    break;

                default:
                    Console.WriteLine("Please choose a correct option");
                    break;
            }



        }
    }
}
