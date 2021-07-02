using System;
using System.IO;
using System.Threading;

namespace RyhmäEsittely
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] path = { "c:/users/muhsen/desktop/MuhsenAlmasry.txt", "c:/users/muhsen/desktop/ari.txt" };
            StreamReader esittelyTeksti;
            for (int i = 0; i < path.Length; i++)
            {
                esittelyTeksti = new StreamReader(path[i]);

                while (esittelyTeksti.Peek() != -1)
                {
                    Console.WriteLine(esittelyTeksti.ReadLine());
                    Thread.Sleep(1500);
                }
                Console.WriteLine("\n\n");
            }
            

        }
    }
}
