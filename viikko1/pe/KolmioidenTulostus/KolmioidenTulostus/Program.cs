using System;

namespace KolmioidenTulostus
{
    class Program
    {
        static void Main(string[] args)
        {
            a:
            Console.Write("Anna komento: ");
            var komento = Console.ReadLine().Split("-");
            var komennot = new int[komento.Length];
            for (int i = 0; i < komento.Length; i++)
            {
                try
                {
                    komennot[i] = Convert.ToInt32(komento[i]);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Väärä merkintä!");
                    goto a;
                }
            }

            for (int i = 0; i < komennot.Length; i++)
            {
                TulostaKolmio(komennot[i]);
            }
        }

        static void TulostaKolmio(int korkeus)
        {
            for (int j = 1; j <= korkeus; j++)
            {
                for (int k = 0; k < j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
