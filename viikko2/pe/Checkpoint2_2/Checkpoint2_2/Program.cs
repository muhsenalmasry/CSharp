using System;
using System.Collections.Generic;

namespace Checkpoint2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna hakemisto: ");
            string hakemisto = Console.ReadLine();
            Console.Write("Anna haettava merkkijono: ");
            string teksti = Console.ReadLine();
            List<Hakutulos> ht = Hakumoottori.Hae(hakemisto, teksti);
            foreach (var item in ht)
            {
                Console.WriteLine("Hakemisto: " + item.Hakemisto + ",\n\t\tTiedosto: " + item.Tiedosto + "\n\t\tRivinumero: " + item.Rivinumero);
            }
        }
    }
}
