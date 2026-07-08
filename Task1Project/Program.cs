namespace Task1Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Personal Info Card
            //////////////////////////////////////
            string name = "Rima ";
            int age = 20;
            double height = 1.55;
            bool student = true;
            Console.WriteLine("Name: " + name + "Age:" + age + "Height: " + height + "Student: " + student);
            //2-  Rectangle Calculator
            //////////////////////////////////////////
            Console.WriteLine("Enter the length : ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width : ");
            int width = int.Parse(Console.ReadLine());

            int area = length * width;
            int perimeter = 2 * (length + width);

            Console.WriteLine("length: " + length);
            Console.WriteLine("width: " + width);
            Console.WriteLine("Area : " + area);
            Console.WriteLine("Perimeter: " + perimeter);
            //3- Even or Odd Checker
            ///////////////////////////////////////////
            Console.WriteLine("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number ");
            }
            else
            {
                Console.WriteLine("Odd Number ");
            }
            //4-Voting Eligibility
            ///////////////////////////////////////////
            Console.WriteLine("enter Your Age : ");
            int userage = int.Parse(Console.ReadLine());
            Console.WriteLine("do you have a valid national ID (yes/no)");

            if (userage >= 18 && Console.ReadLine() == "yes")
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            //5-Grade Letter Lookup
            //////////////////////////////////////////
            Console.WriteLine("enter Your Grade : ");
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
            }
            //6-Temperature Converter
            /////////////////////////////////
            Console.WriteLine("enter a temperature in Celsius : ");
            float celsius = float.Parse(Console.ReadLine());
            float fahrenheit = (celsius * 9 / 5) + 32;
            string weather = "Unknown";
            if (celsius < 10)
            {
                weather = "Cold";
            }
            else if (celsius >= 10 && celsius <= 30)
            {
                weather = "Mild";
            }
            else if (celsius > 30)
            {
                weather = "Hot";
            }
            Console.WriteLine("Temperature in Fahrenheit : " + fahrenheit);
            Console.WriteLine("The weather classification : " + weather);
            //7-Movie Ticket Pricing
            ////////////////////////
            Console.WriteLine("Enter Your Age : ");
            int usrage = int.Parse(Console.ReadLine());
            if (usrage <= 12)
            {
                Console.WriteLine("Children : 2.000 OMR");
            }
            else if (usrage >= 13 && usrage <= 59)
            {
                Console.WriteLine("Adults  : 5.000 OMR");
            }
            else
            {
                Console.WriteLine("Seniors  : 3.000 OMR");
            }
            //8-Restaurant Bill with Membership Discount
            ///////////////////////////////////////////
            Console.WriteLine("Enter Your total bill amount : ");
            int useramount = int.Parse(Console.ReadLine());
            Console.WriteLine("Do You Have a loyalty member (yes/no): ");
            String usermember = Console.ReadLine().ToLower();
            bool isMember = (usermember == "yes");
            float discount = 0;
            float finalAmount = useramount;
            if (useramount > 20 && isMember)
            {
                discount = useramount * 15 / 100;
                finalAmount = useramount - discount;
            }
            Console.WriteLine("Original Bill : " + useramount);
            Console.WriteLine("Discount : " + discount);
            Console.WriteLine("Final Amount : " + finalAmount);
            //9-Day Name Finder
            //////////////////////////////
            Console.WriteLine("Enter a number from 1 to 7:  ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
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
                    Console.WriteLine("Thursday");
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
            //10-Mini Calculator
            ////////////////////
            Console.WriteLine("Enter the first number:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operator (+, -, *, /, %):");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Result = " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("Result = " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Result = " + (num1 * num2));
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result = " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;

                case '%':
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result = " + (num1 % num2));
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
        }
    }
}
