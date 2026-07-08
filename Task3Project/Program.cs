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
            //Task 3 - Name Formatter
            ///////////////////////////
            Console.WriteLine("Enter your full name:");
            string fullName = Console.ReadLine();

            string upperName = fullName.ToUpper();
            string lowerName = fullName.ToLower();
            int characters = fullName.Length;

            Console.WriteLine("Uppercase: " + upperName);
            Console.WriteLine("Lowercase: " + lowerName);
            Console.WriteLine("Character Count: " + characters);
            //Task 4 - Subscription End Date
            /////////////////////////////////////////
            Console.WriteLine("Enter the number of free trial days:");
            int trialDays = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;

            DateTime endDate = today.AddDays(trialDays);

            Console.WriteLine("Trial End Date: " + endDate.ToString("yyyy-MM-dd"));
            //Task 5 - Grade Rounding System
            /////////////////////////////////////////
            Console.WriteLine("Enter your exam score:");
            double score = double.Parse(Console.ReadLine());

            double roundedScore = Math.Round(score);

            Console.WriteLine("Rounded Score: " + roundedScore);

            if (roundedScore >= 60)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }
            //Task 6 - Password Strength Checker
            ///////////////////////////////////////
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            if (password.Length >= 8 && !password.ToLower().Contains("password"))
            {
                Console.WriteLine("Strong Password");
            }
            else
            {
                Console.WriteLine("Weak Password");

                if (password.Length < 8)
                {
                    Console.WriteLine("Reason: Password must be at least 8 characters long.");
                }

                if (password.ToLower().Contains("password"))
                {
                    Console.WriteLine("Reason: Password must not contain the word 'password'.");
                }
            }
            //Task 7 - Clean Name Comparator
            //////////////////////////////////////////
            Console.WriteLine("Enter your name:");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter your name again:");
            string name2 = Console.ReadLine();

            name1 = name1.Trim().ToUpper();
            name2 = name2.Trim().ToUpper();

            if (name1 == name2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }
            //Task 8 - Membership Expiry Checker
            ///////////////////////////////////////////
            Console.WriteLine("Enter Membership Start Date (yyyy-MM-dd):");
            string startText = Console.ReadLine();

            DateTime startDate = DateTime.Parse(startText);

            Console.WriteLine("Enter Membership Days:");
            int membershipDays = int.Parse(Console.ReadLine());

            DateTime expiryDate = startDate.AddDays(membershipDays);

            if (expiryDate >= DateTime.Today)
            {
                Console.WriteLine("Membership Status: Active");
            }
            else
            {
                Console.WriteLine("Membership Status: Expired");
            }

            Console.WriteLine("Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));
            //Task 9 - Round Up / Round Down Explorer
            ////////////////////////////////////////////
            Console.WriteLine("Enter a decimal number:");
            double numbar = double.Parse(Console.ReadLine());

            double nearest = Math.Round(numbar);
            double roundUp = Math.Ceiling(numbar);
            double roundDown = Math.Floor(numbar);

            Console.WriteLine("Nearest Whole Number: " + nearest);
            Console.WriteLine("Rounded Up: " + roundUp);
            Console.WriteLine("Rounded Down: " + roundDown);

        }
    }
}
