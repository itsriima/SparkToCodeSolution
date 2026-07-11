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
        }
    }
}
