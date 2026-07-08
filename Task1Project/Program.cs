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
        }
    }
}
