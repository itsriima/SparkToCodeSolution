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
            //3-Multiplication Table
            //////////////////////
            Console.WriteLine("Enter a Number:");
            int numb = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = numb * i;
                Console.WriteLine(numb + " x " + i + " = " + result);
            }
            //4-Password Retry
            /////////////////////////////////
            string password = "Spark2026";
            string userPassword = "";
            while (userPassword != password)
            {
                Console.WriteLine("Enter Password:");
                userPassword = Console.ReadLine();

                if (userPassword != password)
                {
                    Console.WriteLine("Incorrect password, try again.");
                }
            }
            Console.WriteLine("Access Granted");
        }
    }
}
