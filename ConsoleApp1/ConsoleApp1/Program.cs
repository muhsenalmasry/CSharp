using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Muhsen";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("\aHello world!");
            string name = "Muhsen";

            DialogResult result;
            result = MessageBox.Show($"Hello Mr. {name}", "MyMessageBox", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                Console.WriteLine("Thank you for accepting!");
            }
            else if (result == DialogResult.No)
            {
                Console.WriteLine("Well, it's your loss!");
            }
            else
            {
                Console.WriteLine("Canceled");
            }

            Console.WriteLine("\n\n\n");

            Console.WriteLine("{0:c}", 27.1); //27.1 $
            Console.WriteLine("{0:d1}", 27); //27
            Console.WriteLine("{0:d5}", 27); //00027
            Console.WriteLine("{0:e}", 2700); //2.700000e +003
            Console.WriteLine("{0:f0}", 27); //27
            Console.WriteLine("{0:f3}", 27); //27.000
            Console.WriteLine("{0:g}", 2.7); //2.7
            Console.WriteLine("{0:n}", 2700); //2,700.00
            Console.WriteLine("{0:x}", 27); //1b

            
            int x = 5, y = 0;
            try
            {
                Console.WriteLine(x / y);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            a:
            Console.WriteLine("divide by ?");
            y = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(x/y);
            }
            catch (Exception)
            {
                goto a;
            }
            


        }
    }
}
