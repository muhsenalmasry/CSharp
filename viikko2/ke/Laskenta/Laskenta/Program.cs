using System;

namespace Laskenta
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku:");
            try
            {
                int luku = int.Parse(Console.ReadLine());
                Console.WriteLine(luku.Kertotaulu());
                Console.WriteLine(luku.Kertoma());
            }
            catch (Exception e)
            {
                Console.WriteLine("Väärä muotoinen luku!");
            }

        }
        public static string Kertotaulu(this int luku)
        {
            string kertotaulu = "";
            for (int i = 1; i <= 10; i++)
            {
                kertotaulu += String.Format("{0,2} * {1,2}  = {2,2}\n", i, luku, i * luku);
            }
            return kertotaulu;
        }
        public static string Kertoma(this int luku)
        {
            string kertoma = "";
            for (int i = 1; i <= luku; i++)
            {
                if (i != luku)
                    kertoma += String.Format("{0,2} * ", i);
                else
                    kertoma += String.Format("{0,2}", i);
            }
            kertoma += "\n";
            return kertoma;
        }
    }
}
