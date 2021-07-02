using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rectangle";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Enter width of rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of rectangle:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A = {0}", width*height);
            Console.WriteLine("P = {0}", 2*(width+height));
        }
    }
}
