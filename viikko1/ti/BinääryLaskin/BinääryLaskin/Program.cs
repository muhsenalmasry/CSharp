using System;

namespace BinääryLaskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BinääryLaskin";

            int number1, number2;
            string operation;

            a:
            Console.WriteLine("Anna laksu:");
            var array = Console.ReadLine().Split(" ");

            number1 = Convert.ToInt32(array[0], 2);
            number2 = Convert.ToInt32(array[2], 2);

            operation = array[1];
            if (operation.Equals("+"))
            {
                Console.WriteLine(Convert.ToString(number1+number2, 2));
            }
            else if (operation.Equals("-"))
            {
                Console.WriteLine(Convert.ToString(number1 - number2, 2));
            }
            else if (operation.Equals("*"))
            {
                Console.WriteLine(Convert.ToString(number1 * number2, 2));
            }
            else if (operation.Equals("/"))
            {
                Console.WriteLine(Convert.ToString(number1 / number2, 2));
            }
            else
            {
                Console.WriteLine("Kokeile uudelleen!");
            }
        }
    }
}
