using Microsoft.Win32;

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
        static Student S1 = new Student();
        static Student S2 = new Student();
        static Product P1 = new Product();
        static Product P2 = new Product();
        static void Main(string[] args)
            {
            // - Create sample accounts
            // Bank Accounts
            B1.AccountNumber = 1001;
            B1.HolderName = "Karim";
            B1.Balance = 500;

            B2.AccountNumber = 1002;
            B2.HolderName = "Ali";
            B2.Balance = 300;

            // Students
            S1.Name = "Ahmed";
            S1.Address = "Muscat";
            S1.Grade = 90;

            S2.Name = "Ali";
            S2.Address = "Nizwa";
            S2.Grade = 85;

            // Products
            P1.ProductName = "Laptop";
            P1.Price = 250;
            P1.StockQuantity = 10;

            P2.ProductName = "Mouse";
            P2.Price = 20;
            P2.StockQuantity = 30;
            RestockProduct();
        }
        static void ViewAccountDetails()
        {
            Console.WriteLine("Choose an account:");
            Console.WriteLine("1. " + B1.HolderName);
            Console.WriteLine("2. " + B2.HolderName);

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
            //Case 2 - Update Student Address
            ///////////////////////////////////
            static void UpdateStudentAddress()
            {
                Console.WriteLine("Choose a student:");
                Console.WriteLine("1. " + S1.Name);
                Console.WriteLine("2. " + S2.Name);

                int choice = int.Parse(Console.ReadLine());

                Console.Write("Enter the new address: ");
                string newAddress = Console.ReadLine();

                if (choice == 1)
                {
                    S1.Address = newAddress;
                    Console.WriteLine("Address updated to: " + S1.Address);
                }
                else if (choice == 2)
                {
                    S2.Address = newAddress;
                    Console.WriteLine("Address updated to: " + S2.Address);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            //Case 3 - Make a Deposit
            //////////////////////////////////
            static void MakeDeposit()
            {
                Console.WriteLine("Choose an account:");
                Console.WriteLine("1. " + B1.HolderName);
                Console.WriteLine("2. " + B2.HolderName);

                int choice = int.Parse(Console.ReadLine());

                Console.Write("Enter deposit amount: ");
                double amount = double.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    B1.Deposit(amount);

                    Console.WriteLine("Holder Name: " + B1.HolderName);
                    Console.WriteLine("Updated Balance: " + B1.Balance);
                }
                else if (choice == 2)
                {
                    B2.Deposit(amount);

                    Console.WriteLine("Holder Name: " + B2.HolderName);
                    Console.WriteLine("Updated Balance: " + B2.Balance);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
                //Case 4 - Make a Withdrawal
                /////////////////////////////
                static void MakeWithdrawal()
                {
                    Console.WriteLine("Choose an account:");
                    Console.WriteLine("1. " + B1.HolderName);
                    Console.WriteLine("2. " + B2.HolderName);

                    int choice = int.Parse(Console.ReadLine());

                    Console.Write("Enter withdrawal amount: ");
                    double amount = double.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        B1.Withdraw(amount);

                        Console.WriteLine("Updated Balance: " + B1.Balance);
                    }
                    else if (choice == 2)
                    {
                        B2.Withdraw(amount);

                        Console.WriteLine("Updated Balance: " + B2.Balance);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }

                }
        //Case 5 - View Product Details
        /////////////////////////////////
        static void ViewProductDetails()
        {
            Console.WriteLine("Choose a product:");
            Console.WriteLine("1. " + P1.ProductName);
            Console.WriteLine("2. " + P2.ProductName);

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                double value = P1.GetInventoryValue();
                Console.WriteLine("Inventory Value: " + value);
            }
            else if (choice == 2)
            {
                double value = P2.GetInventoryValue();
                Console.WriteLine("Inventory Value: " + value);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        //Case 6 - Register a Student
        /////////////////////////////////////
        static void RegisterStudent()
        {
            Console.WriteLine("Choose a student:");
            Console.WriteLine("1. " + S1.Name);
            Console.WriteLine("2. " + S2.Name);

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            if (choice == 1)
            {
                S1.Register(email);
                Console.WriteLine(S1.Name + " has been registered successfully.");
            }
            else if (choice == 2)
            {
                S2.Register(email);
                Console.WriteLine(S2.Name + " has been registered successfully.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        //Case 7 - Compare Two Account Balances
        //////////////////////////////////////
        static void CompareAccountBalances()
        {
            if (B1.Balance > B2.Balance)
            {
                Console.WriteLine(B1.HolderName + " has more money.");
            }
            else if (B2.Balance > B1.Balance)
            {
                Console.WriteLine(B2.HolderName + " has more money.");
            }
            else
            {
                Console.WriteLine("Both accounts have the same balance.");
            }
        }
        //Case 8 - Restock Product & Stock Level Check
        //////////////////////////////////////////////
        static void RestockProduct()
        {
            Console.WriteLine("Choose a product:");
            Console.WriteLine("1. " + P1.ProductName);
            Console.WriteLine("2. " + P2.ProductName);

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter quantity to add: ");
            int quantity = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                P1.Restock(quantity);

                if (P1.StockQuantity < 10)
                {
                    Console.WriteLine("Stock Level: Low");
                }
                else if (P1.StockQuantity >= 10 && P1.StockQuantity <= 49)
                {
                    Console.WriteLine("Stock Level: Moderate");
                }
                else
                {
                    Console.WriteLine("Stock Level: Well Stocked");
                }
            }
            else if (choice == 2)
            {
                P2.Restock(quantity);

                if (P2.StockQuantity < 10)
                {
                    Console.WriteLine("Stock Level: Low");
                }
                else if (P2.StockQuantity >= 10 && P2.StockQuantity <= 49)
                {
                    Console.WriteLine("Stock Level: Moderate");
                }
                else
                {
                    Console.WriteLine("Stock Level: Well Stocked");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}





