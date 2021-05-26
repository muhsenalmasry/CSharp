using System;
using System.Collections.Generic;
using System.Linq;

namespace ostoslista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä tuotteet ja niiden hinnat!");

            List<OstosLista> ostosLista = new List<OstosLista> ();

            string tuotteenNimi;
            double tuotteenHinta;

            while (true)
            {
                Console.WriteLine("\n\nTuoteen nimi:");
                tuotteenNimi = Console.ReadLine();
                Console.WriteLine("Tuotten hinta:");
                tuotteenHinta = Convert.ToDouble(Console.ReadLine());

                ostosLista.Add(new OstosLista(tuotteenNimi, tuotteenHinta));

                Console.WriteLine("Jatketaanko? (y/n)");
                string vastaus = Console.ReadLine();
                if(vastaus.ToLower() == "n")
                {
                    break;
                }

            }

            ostosLista = ostosLista.OrderBy(i => i.Hinta).ToList();


            Console.WriteLine($"Halvin tuote on: {ostosLista[0]}");
            Console.WriteLine($"Kallein tuote on: {ostosLista.Last()}");
            
            
        }
    }

    class OstosLista
    {
        public string Tuote
        { get; set; }
        
        public double Hinta
        { get; set; }

        public OstosLista(string tuote = "Tuntematon", double hinta = 0)
        {
            Tuote = tuote;
            Hinta = hinta;
        }

        public override string ToString()
        {
            return $"{Tuote} maksaa {Hinta} euroa.";
        }
    }
}
