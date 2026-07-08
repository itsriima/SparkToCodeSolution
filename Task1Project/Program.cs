namespace Task1Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Personal Info Card
            //////////////////////////////////////
            string name = "Rima ";
            int age = 20;
            double height = 1.55;
            bool student = true;
            Console.WriteLine("Name: " + name + "Age:" + age + "Height: " + height + "Student: " + student);
            //2-  Rectangle Calculator
            //////////////////////////////////////////
            Console.WriteLine("Enter the length : ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width : ");
            int width = int.Parse(Console.ReadLine());

            int area = length * width;
            int perimeter = 2 * (length + width);

            Console.WriteLine("length: " + length);
            Console.WriteLine("width: " + width);
            Console.WriteLine("Area : " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }
    }
}
