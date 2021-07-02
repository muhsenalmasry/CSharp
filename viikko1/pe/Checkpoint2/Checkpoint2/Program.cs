using System;

namespace Checkpoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Laite vatkain = new Laite(352402, "Suristin X15");
            vatkain.Kuvaus = "Markkinoiden hiljaisin tehokkaasti pärisevä vatkain";
            vatkain.Valmistusmaa = "SUOMI";
            vatkain.PakkauksenKoko(12, 12, 38); // leveys, korkeus, syvyys
            Console.WriteLine(vatkain);
        }
    }
}
