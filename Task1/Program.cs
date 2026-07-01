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
            double perimeter = 2 * (length + width);

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
            }
            else
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

            Console.WriteLine("Original Bill: " + bill);
            Console.WriteLine("Discount Amount: " + discount);
            Console.WriteLine("Final Amount:  " + finalAmount);

            //  Medium-task9 
            Console.Write("Enter a number from 1 to 7: ");
            int dayNum = int.Parse(Console.ReadLine());
            switch (dayNum)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thersday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
            //Medium-task10 

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter operator +, -, *, /,%: ");
            char op = char.Parse(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;
                case '%':
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result: " + (num1 % num2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }

                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            //Hard-task11 
            Console.WriteLine("Enter your age: ");
            int age4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your monthly income: ");
            double income = double.Parse(Console.ReadLine());

            Console.WriteLine("Do you have an existing loan? yes/no: ");
            string loan = Console.ReadLine();
            bool hasLoan = loan == "yes";

            if (age4 >= 21 && age4 <= 60 && income >= 400 && !hasLoan)
            {
                Console.WriteLine("Eligible for loan");
            }
            else
            {
                Console.WriteLine("Not eligible for loan");
            }
            if (age4 < 21 || age4 > 60)
            {
                Console.WriteLine("Reason: age out of range");
            }
            if (income < 400)
            {
                Console.WriteLine("Reason: income too low");
            }
            if (hasLoan)
            {
                Console.WriteLine("Reason: has an existing loan");
            }
            //Hard-task12 
            Console.WriteLine("Enter region code A,B,C: ");
            char region = char.Parse(Console.ReadLine());

            Console.Write("Enter package weight in kg: ");
            double weight = double.Parse(Console.ReadLine());

            double baseCost = 0;
            double extraCharge = 0;
            double totalCost = 0;
            switch (region)
            {
                case 'A':
                    baseCost = 3;
                    if (weight > 5)
                    {
                        extraCharge = 2;
                    }
                    else if (weight > 10)
                    {
                        extraCharge = 5;
                    }
                    else
                    {
                        extraCharge = 0;
                    }
                    totalCost = baseCost + extraCharge;
                    Console.WriteLine("Base Cost :" + baseCost);
                    Console.WriteLine("Extra Charge :" + extraCharge);
                    Console.WriteLine("Total Cost :" + totalCost);
                    break;
                case 'B':
                    baseCost = 1;
                    if (weight > 5)
                    {
                        extraCharge = 2;
                    }
                    else if (weight > 10)
                    {
                        extraCharge = 5;
                    }
                    else
                    {
                        extraCharge = 0;
                    }
                    totalCost = baseCost + extraCharge;
                    Console.WriteLine("Base Cost :" + baseCost);
                    Console.WriteLine("Extra Charge :" + extraCharge);
                    Console.WriteLine("Total Cost :" + totalCost);
                    break;
                case 'C':
                    baseCost = 7;
                    if (weight > 5)
                    {
                        extraCharge = 2;
                    }
                    else if (weight > 10)
                    {
                        extraCharge = 5;
                    }
                    else
                    {
                        extraCharge = 0;
                    }
                    totalCost = baseCost + extraCharge;
                    Console.WriteLine("Base Cost :" + baseCost);
                    Console.WriteLine("Extra Charge :" + extraCharge);
                    Console.WriteLine("Total Cost :" + totalCost);
                    break;

            }
            //Hard-task13 
            Console.WriteLine("Enter side 1 : ");
            double side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter side 2 : ");
            double side2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter side 3 : ");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("Valid triangle");
                    Console.WriteLine("Type: Equilateral");
                }
                else
                {
                    if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("Valid triangle");
                        Console.WriteLine("Type: Isosceles");
                    }
                    else
                    {
                        Console.WriteLine("The sides do not form a valid triangle");
                    }






                }
            }
            //Advanced-task14 
            Console.WriteLine("enter product code 1,2,3 : ");
            int proCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Do you have a discount coupon? yes/no: ");
            string coupon = Console.ReadLine();

            bool hasCoupon = coupon == "yes";
            string proName = "";
            double unitPrice = 0;
            bool validPro = true;
            switch (proCode)
            {
                case 1:
                    proName = "Heasphones";
                    unitPrice = 8.5;

                    break;
                case 2:
                    proName = "Keyboard";
                    unitPrice = 12;
                    break;
                case 3:
                    proName = "Mouse";
                    unitPrice = 5;
                    break;
                default:
                    Console.WriteLine("Invalid product code");
                    break;
            }
            if (validPro)
            {
                double subtotal = unitPrice * quantity;
                double discAmount = 0;
                if (hasCoupon && subtotal > 20)
                {
                    discAmount = subtotal * 0.10;
                }
                double afterdis = subtotal - discAmount;
                double tax = afterdis * 0.05;
                double finalTotal = afterdis + tax;
                Console.WriteLine("Product: " + proName);
                Console.WriteLine("Subtotal:" + subtotal);
                Console.WriteLine("Discount Amount:" + discAmount);
                Console.WriteLine("Tax Amount: " + tax);
                Console.WriteLine("Final Total:" + finalTotal);

            }
            //Advanced-task15 
            Console.Write("Enter program type S for Science or A for Arts: ");
            char programType = char.Parse(Console.ReadLine());

            Console.Write("Enter GPA out of 4.0: ");
            double gpa = double.Parse(Console.ReadLine());

            Console.Write("Enter entrance exam score out of 100: ");
            int examScore = int.Parse(Console.ReadLine());

            Console.Write("Do you have an extracurricular achievement? yes/no: ");
            string achievement = Console.ReadLine();
            bool hasAchievement = achievement == "yes";
            string pName = "";
            string result1 = "";
            bool vProgram = true;
            switch (programType)
            {
                case 'S':
                    pName = "Science";

                    if (gpa >= 3.0 && examScore >= 75)
                    {
                        result1 = "Admitted";
                    }
                    else
                    {
                        if (hasAchievement)
                        {
                            result1 = "Conditionally Admitted";
                        }
                        else
                        {
                            result1 = "Not Admitted";
                        }
                    }
                    break;
                case 'A':
                    pName = "Arts";

                    if (gpa >= 2.5 && examScore >= 60)
                    {
                        result1 = "Admitted";
                    }
                    else
                    {
                        if (hasAchievement)
                        {
                            result1 = "Conditionally Admitted";
                        }
                        else
                        {
                            result1 = "Not Admitted";
                        }
                    }
                    break;
                default:
                    vProgram = false;
                    Console.WriteLine("Invalid program type");
                    break;
            }

            if (vProgram)
            {
                Console.WriteLine("Program Type: " + pName);
                Console.WriteLine("Final Result: " + result1);
            }
            
        

        }

        }
    }

