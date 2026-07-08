namespace Task4Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function
            ///////////////////////////////////////////
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            PrintWelcome(userName);
            //Task 2 - Square Number Function
            ///////////////////////////////////////////
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            int result = Square(number);

            Console.WriteLine("Square = " + result);
            //Task 3 - Celsius to Fahrenheit Function
            //////////////////////////////////////////
            Console.WriteLine("Enter the temperature in Celsius:");
            double usernumber = double.Parse(Console.ReadLine());
            double result1 = CelsiusToFahrenheit(usernumber);
            Console.WriteLine("CelsiusToFahrenheit = " + result1);
            //Task 4 - Fixed Menu Display Function
            //////////////////////////////////////////
            static void Main(string[] args)
            {
                DisplayMenu();
            }
            //Task 5 - Even or Odd Function
            /////////////////////////////
            Console.WriteLine("Enter a number:");
            int typenumber = int.Parse(Console.ReadLine());
            bool resultype = IsEven(typenumber);
            if (resultype)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
            //Task 6 - Rectangle Area & Perimeter Functions
            ///////////////////////////////////////////////
            Console.WriteLine("Enter a Length:");
            double Lnumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Width:");
            double Wnumber = double.Parse(Console.ReadLine());
            double CPresult = CalculatePerimeter(Lnumber, Wnumber);
            double Cresult = CalculateArea(Lnumber, Wnumber);

        }
        //1
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
        }
        //2
        static int Square(int number)
        {
            return number * number;
        }
        //3
        static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        //4
        static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }
        //5
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        //6
        static double CalculateArea(double length, double width)
        {
            double Cresult = length * width;
            return Cresult;
        }

        static double CalculatePerimeter(double length, double width)
        {
            double Cpresult = 2 * (length + width);
            return Cpresult;
        }
    }
}
