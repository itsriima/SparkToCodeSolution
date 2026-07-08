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

        }
    }
}
