namespace Task5Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Fixed Grades Array
            ////////////////////////////
            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Student Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
            //Task 2 - Dynamic To-Do List
            //////////////////////////////
            List<string> tasks = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter task " + (i + 1) + ": ");
                string task = Console.ReadLine();

                tasks.Add(task);
            }
            Console.WriteLine("To-Do List:");

            foreach (string task in tasks)
            {
                Console.WriteLine("- " + task);
            }
            //Task 3 - Browsing History Stac
            /////////////////////////////////////
            Stack<string> history = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter website URL: ");
                string website = Console.ReadLine();

                history.Push(website);
            }

            history.Pop();

            Console.WriteLine("Current page: " + history.Peek());
            //Task 4 - Customer Service Queue
            ////////////////////////////////////////
            Queue<string> customers = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter customer name: ");
                string name = Console.ReadLine();

                customers.Enqueue(name);
            }

            string servedCustomer = customers.Dequeue();

            Console.WriteLine("Served customer: " + servedCustomer);
            //Task 5 - Array Grade Range
            ///////////////////////////////////////////
            int[] scores = new int[5];
            int sum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("Enter scores " + (i + 1) + ": ");
                scores[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(scores);

            for (int i = 0; i < grades.Length; i++)
            {
                sum += scores[i];
            }

            double average = (double)sum / scores.Length;

            Console.WriteLine("Lowest Grade: " + scores[0]);
            Console.WriteLine("Highest Grade: " + scores[scores.Length - 1]);
            Console.WriteLine("Average Grade: " + average);
        }
    }
}
