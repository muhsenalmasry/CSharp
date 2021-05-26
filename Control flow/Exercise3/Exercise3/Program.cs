using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the image:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the image:");
            double height = Convert.ToDouble(Console.ReadLine());
            if (width > height)
            {
                Console.WriteLine("It's a landscape!");
            }
            else
            {
                Console.WriteLine("It's a portrait!");
            }
        }
    }
}
