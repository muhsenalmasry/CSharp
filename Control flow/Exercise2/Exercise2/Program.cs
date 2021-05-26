using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double max = number1 < number2 ? number2 : number1;
            Console.WriteLine("The maximum value of the two is: {0}.", max);
        }
    }
}
