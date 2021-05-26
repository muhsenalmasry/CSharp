using System;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            if(number > 0 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
            }
    }
}
