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
        }
    }
}
