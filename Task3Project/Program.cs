namespace Task3Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Absolute Difference
            /////////////////////////////
            Console.WriteLine("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            int difference = firstNumber - secondNumber;
            int positiveDifference = Math.Abs(difference);
            Console.WriteLine("Absolute Difference: " + positiveDifference);
            //Task 2 - Power & Root Explorer
            ////////////////////////////////
            Console.WriteLine("Enter a Number:");
            double number = double.Parse(Console.ReadLine());
            double square = Math.Pow(number, 2);
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("Square: " + square);
            Console.WriteLine("Square Root: " + squareRoot);

        }
    }
}
