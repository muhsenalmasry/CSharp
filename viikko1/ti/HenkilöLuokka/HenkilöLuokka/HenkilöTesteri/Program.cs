using System;
using HenkilöLuokka;

namespace HenkilöTesteri
{
    class HenkilöTesteri
    {
        static void Main(string[] args)
        {
            Henkilö[] hlot = { new Henkilö ("Jaska", "Jokunen", 21),
                new Henkilö("Maija", "Meikäläinen", 28),
                new Henkilö("John", "Doe", 55),
                new Henkilö("John", "Deere", 21),
                new Henkilö("Musta", "Naamio", 355)
            };
            foreach (var h in hlot)
            {
                Console.WriteLine(h);
            }
        }
    }
}
