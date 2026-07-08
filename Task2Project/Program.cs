namespace Task2Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Countdown Timer
            ///////////////////////
            Console.WriteLine("Enter a Number:");
            int startNumber = int.Parse(Console.ReadLine());
            for (int i = startNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");
            //2 - Sum of Numbers 1 to N
            ////////////////////////////
            Console.WriteLine("Enter a positive number:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("The total sum is: " + sum);
        }
    }
}
