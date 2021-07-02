using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Laskuri";
            double number1, number2;
            string operation;

            a:
            Console.WriteLine("Anna lasku:");
            string str = Console.ReadLine();

            string[] array = str.Split(" ");
            Console.WriteLine(array[0]);
            try
            {
                number1 = Convert.ToDouble(array[0]);
                //Console.WriteLine(number1);
                number2 = Convert.ToDouble(array[2]);
                //Console.WriteLine(number2);
                operation = array[1];
                //Console.WriteLine(operation);
                if (operation.Equals("+"))
                {
                    Console.WriteLine("Laskun tulos = {0}", number1 + number2);
                }
                else if (operation.Equals("-"))
                {
                    Console.WriteLine("Laskun tulos = {0}", number1 - number2);
                }
                else if (operation.Equals("*"))
                {
                    Console.WriteLine("Laskun tulos = {0}", number1 * number2);
                }
                else if (operation.Equals("/"))
                {
                    Console.WriteLine("Laskun tulos = {0}", Math.Round(number1 / number2, 2));
                }
                else
                {
                    Console.WriteLine("Väärä lasku");
                    goto a;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Oops, Joku meni pieleen! Kokeile uudelleen");
                goto a;
            }
            /*
            a:
            Console.WriteLine("Anna ensimmäinen luku:");
            try
            {
                number1 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Kokeile uudelleen!");
                goto a;
            }

            b:
            Console.WriteLine("Anna toinen luku:");
            try
            {
                number2 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Kokeile uudelleen!");
                goto b;
            }

            c:
            Console.WriteLine("Anna operaatio:");
            operation = Console.ReadLine();

            if (operation.Equals("+"))
            {
                Console.WriteLine("Sum = {0}", number1 + number2);
            }
            else if (operation.Equals("-"))
            {
                Console.WriteLine("Sum = {0}", number1 - number2);
            }
            else if(operation.Equals("*"))
            {
                Console.WriteLine("Sum = {0}", number1 * number2);
            }
            else if (operation.Equals("/"))
            {
                Console.WriteLine("Sum = {0}", Math.Round(number1 / number2 , 2));
            }
            else
            {
                Console.WriteLine("Kokeile uudelleen!");
                goto c;
            }*/
        }
    }
}
