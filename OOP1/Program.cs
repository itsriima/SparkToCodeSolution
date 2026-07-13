namespace OOP1
{
    //1- class BankAccount
    /////////////////////////////
    public class BankAccount
    {
        // Properties
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        // Methods
        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }

        private void SendEmail()
        {
            // Placeholder for email notification
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }

            SendEmail();
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }
    }
    //2-class Student
    ///////////////////////////////////
    public class Student
    {
        // Properties
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email { get; set; }

        int age { get; set; }

        // Methods
        public void Register(string Email)
        {
            email = Email;

            SendEmail();
        }

        private void SendEmail()
        {
            // Placeholder for registration email
        }
    }
    //3- class Product
    ///////////////////////////////////
    public class Product
    {
        // Properties
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        // Methods
        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock.");
            }

            LogTransaction();
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;

            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();

            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Stock Quantity: " + StockQuantity);
        }

        private void LogTransaction()
        {
            // Placeholder for transaction logging
        }
    }
        internal class Program
        {
            static BankAccount B1 = new BankAccount();
            static BankAccount B2 = new BankAccount();
            static void Main(string[] args)
            {
            //1- class 1
            B1.AccountNumber = 1001;
            B1.HolderName = "Karim";
            B1.Balance = 500;

            B2.AccountNumber = 1002;
            B2.HolderName = "Ali";
            B2.Balance = 300;

            ViewAccountDetails();
            //2- class 2
            Console.WriteLine("Choose an account:");
            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                B1.CheckBalance();
            }
            else if (choice == 2)
            {
                B2.CheckBalance();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

        }
            static void ViewAccountDetails()
            {

            }

        }
}



