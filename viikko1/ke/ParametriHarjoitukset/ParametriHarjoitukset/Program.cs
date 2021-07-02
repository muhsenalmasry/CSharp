using System;


namespace ParametriHarjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
        }

        static void Test1()
        {
            Testipenkki tp = new Testipenkki();
            Console.WriteLine(tp.NimiKuntoon("jeremias", "yli-rotiala"));
            Console.WriteLine(tp.NimiKuntoon("MUhsen alMAsry"));
            string varoitukset;
            string virheet;
            Tuote tomaatti = new Tuote(999, "Tomaatti", 0);
            bool kaikkiok = tp.TarkistaTuote(tomaatti, out virheet, out varoitukset);
            if (!kaikkiok)
            {
                Console.WriteLine(virheet);
                Console.WriteLine(varoitukset);
            }

            int tulos = tp.LaskeYhteen(1, 5, 66, 12, 99);
            Console.WriteLine(tulos);

            string[] nimet = tp.TeeTaulukko("Aku", "Pelle", "Roope", "Iines");
            for (int i = 0; i < nimet.Length; i++)
            {
                Console.Write(nimet[i]);
                if(i == nimet.Length - 1)
                {
                    Console.WriteLine(".");
                }
                else
                    Console.Write(", ");
            }
        }
    }
}
