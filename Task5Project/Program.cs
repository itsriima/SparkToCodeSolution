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
            //Task 6 - Filtered Shopping List
            //////////////////////////////////////
            List<string> shoppingList = new List<string>();

            while (true)
            {
                Console.Write("Enter an item (or type done to finish): ");
                string itemName = Console.ReadLine();

                if (itemName.ToLower() == "done")
                {
                    break;
                }

                shoppingList.Add(itemName);
            }
            Console.WriteLine("Shopping List Before Removal:");
            foreach (string item in shoppingList)
            {
                Console.WriteLine("- " + item);
            }
            Console.Write("Enter an item to remove: ");
            string removeItem = Console.ReadLine();

            shoppingList.Remove(removeItem);

            Console.WriteLine("Shopping List After Removal:");

            foreach (string item in shoppingList)
            {
                Console.WriteLine("- " + item);
            }
            //Task 7 - High Score Podium
            //////////////////////////////////////////
            List<int> gameScores = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter game score " + (i + 1) + ": ");
                int scoreValue = int.Parse(Console.ReadLine());
                gameScores.Add(scoreValue);
            }
            gameScores.Sort();
            gameScores.Reverse();

            Console.WriteLine("Top 3 Scores:");
            Console.WriteLine("1st Place: " + gameScores[0]);
            Console.WriteLine("2nd Place: " + gameScores[1]);
            Console.WriteLine("3rd Place: " + gameScores[2]);
            //Task 8 - Undo Last Action
            ////////////////////////////////////////////
            Stack<string> actionStack = new Stack<string>();
            while (true)
            {
                Console.Write("Enter an action (or type stop): ");
                string editorAction = Console.ReadLine();
                if (editorAction.ToLower() == "stop")
                {
                    break;
                } 
                actionStack.Push(editorAction);
            }
            Console.WriteLine("Undo Actions:");

            if (actionStack.Count > 0)
            {
                Console.WriteLine("Undo: " + actionStack.Pop());
            }
            if (actionStack.Count > 0)
            {
                Console.WriteLine("Undo: " + actionStack.Pop());
            }
            Console.WriteLine("Remaining Actions:");

            foreach (string remainingAction in actionStack)
            {
                Console.WriteLine(remainingAction);
            }
        }
    }
}
