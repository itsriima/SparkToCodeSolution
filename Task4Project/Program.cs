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
        }
        //1
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
        }

    }
}
