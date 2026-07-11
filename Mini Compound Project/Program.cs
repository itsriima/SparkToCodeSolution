
        internal class Program
        {
            // Shared Lists
            static List<string> customerNames = new List<string>();
            static List<string> accountNumbers = new List<string>();
            static List<double> balances = new List<double>();

            static void Main(string[] args)
            {
                bool exitApp = false;

                while (!exitApp)
                {
                    Console.WriteLine("========== Banking System ==========");
                    Console.WriteLine("1. Add New Account");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Show Balance");
                    Console.WriteLine("5. Transfer Amount");
                    Console.WriteLine("6. Custom Service 1");
                    Console.WriteLine("7. Custom Service 2");
                    Console.WriteLine("8. Exit");
                    Console.Write("Choose an option: ");

                    try
                    {
                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                AddAccount();
                                break;

                            case 2:
                                DepositMoney();
                                break;

                            case 3:
                                WithdrawMoney();
                                break;

                            case 4:
                                ShowBalance();
                                break;

                            case 5:
                                TransferAmount();
                                break;

                            case 6:
                                DisplayAllAccounts();
                                break;

                            case 7:
                                DeleteAccount();
                                break;

                            case 8:
                                exitApp = true;
                                Console.WriteLine("Thank you for using the Banking System.");
                                break;

                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }

                    Console.WriteLine();
                }
            }

            // Service 1
            static void AddAccount()
            {
                Console.Write("Enter customer name: ");
                string customerName = Console.ReadLine();

                Console.Write("Enter account number: ");
                string accountNumber = Console.ReadLine();

                if (accountNumbers.Contains(accountNumber))
                {
                    Console.WriteLine("Account number already exists.");
                    return;
                }

                Console.Write("Enter initial deposit: ");
                double initialBalance = double.Parse(Console.ReadLine());

                if (initialBalance < 0)
                {
                    Console.WriteLine("Balance cannot be negative.");
                    return;
                }

                customerNames.Add(customerName);
                accountNumbers.Add(accountNumber);
                balances.Add(initialBalance);

                Console.WriteLine("Account created successfully!");
            }

            // Service 2
            static void DepositMoney()
            {
                Console.Write("Enter account number: ");
                string accountNumber = Console.ReadLine();

                int index = accountNumbers.IndexOf(accountNumber);

                if (index == -1)
                {
                    Console.WriteLine("Account not found.");
                    return;
                }

                Console.Write("Enter deposit amount: ");
                double depositAmount = double.Parse(Console.ReadLine());

                if (depositAmount <= 0)
                {
                    Console.WriteLine("Invalid amount.");
                    return;
                }

                balances[index] += depositAmount;

                Console.WriteLine("Deposit successful.");
                Console.WriteLine("New Balance: " + balances[index]);
            }
                // Service 3
                static void WithdrawMoney()
            {
                Console.Write("Enter account number: ");
                string accountNumber = Console.ReadLine();

                int index = accountNumbers.IndexOf(accountNumber);

                if (index == -1)
                {
                    Console.WriteLine("Account not found.");
                    return;
                }

                Console.Write("Enter withdraw amount: ");
                double withdrawAmount = double.Parse(Console.ReadLine());

                if (withdrawAmount <= 0)
                {
                    Console.WriteLine("Invalid amount.");
                    return;
                }

                if (withdrawAmount > balances[index])
                {
                    Console.WriteLine("Insufficient balance.");
                    return;
                }

                balances[index] -= withdrawAmount;

                Console.WriteLine("Withdrawal successful.");
                Console.WriteLine("New Balance: " + balances[index]);
            }

            // Service 4
            static void ShowBalance()
            {
                Console.Write("Enter account number: ");
                string accountNumber = Console.ReadLine();
                int index = accountNumbers.IndexOf(accountNumber);

                if (index == -1)
                {
                    Console.WriteLine("Account not found.");
                    return;
                }
                Console.WriteLine("Customer Name: " + customerNames[index]);
                Console.WriteLine("Account Number: " + accountNumbers[index]);
                Console.WriteLine("Current Balance: " + balances[index]);
            }

            // Service 5
            static void TransferAmount()
            {
                // Ask for sender account
                Console.Write("Enter sender account number: ");
                string senderAccount = Console.ReadLine();

                int senderIndex = accountNumbers.IndexOf(senderAccount);

                if (senderIndex == -1)
                {
                    Console.WriteLine("Sender account not found.");
                    return;
                }

                // Ask for receiver account
                Console.Write("Enter receiver account number: ");
                string receiverAccount = Console.ReadLine();

                int receiverIndex = accountNumbers.IndexOf(receiverAccount);

                if (receiverIndex == -1)
                {
                    Console.WriteLine("Receiver account not found.");
                    return;
                }

                // Prevent transferring to the same account
                if (senderIndex == receiverIndex)
                {
                    Console.WriteLine("Cannot transfer to the same account.");
                    return;
                }

                // Ask for amount
                Console.Write("Enter transfer amount: ");
                double transferAmount = double.Parse(Console.ReadLine());

                if (transferAmount <= 0)
                {
                    Console.WriteLine("Invalid amount.");
                    return;
                }

                if (transferAmount > balances[senderIndex])
                {
                    Console.WriteLine("Insufficient balance.");
                    return;
                }

                // Transfer money
                balances[senderIndex] -= transferAmount;
                balances[receiverIndex] += transferAmount;

                Console.WriteLine("Transfer completed successfully!");

                Console.WriteLine();

                Console.WriteLine("Sender Balance: " + balances[senderIndex]);
                Console.WriteLine("Receiver Balance: " + balances[receiverIndex]);
            }
            // Service 6 - Display All Accounts
            static void DisplayAllAccounts()
            {
                if (customerNames.Count == 0)
                {
                    Console.WriteLine("No accounts found.");
                    return;
                }

                Console.WriteLine("========== All Accounts ==========");

                for (int i = 0; i < customerNames.Count; i++)
                {
                    Console.WriteLine("Customer Name : " + customerNames[i]);
                    Console.WriteLine("Account Number: " + accountNumbers[i]);
                    Console.WriteLine("Balance       : " + balances[i]);
                    Console.WriteLine("------------------------------");
                }
            }
                // Service 7 - Delete Account
                static void DeleteAccount()
                {
                    Console.Write("Enter account number to delete: ");
                    string accountNumber = Console.ReadLine();

                    int index = accountNumbers.IndexOf(accountNumber);

                    if (index == -1)
                    {
                        Console.WriteLine("Account not found.");
                        return;
                    }
                    customerNames.RemoveAt(index);
                    accountNumbers.RemoveAt(index);
                    balances.RemoveAt(index);
                    Console.WriteLine("Account deleted successfully.");
                }
        }

        

    

    
