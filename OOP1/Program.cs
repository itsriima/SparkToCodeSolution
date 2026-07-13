namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
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
    }
    }

