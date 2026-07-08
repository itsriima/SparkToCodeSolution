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

    }
}
