using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2
{
    class Laite
    {
        public int leveys, korkeus, syvyys;
        public int Tuotenro { get; set; }
        public string Tuotenimi { get; set; }
        public string Kuvaus { get; set; }
        public string Valmistusmaa { get; set; }

        public void PakkauksenKoko (int lev, int kork, int syv)
        {
            leveys = lev;
            korkeus = kork;
            syvyys = syv;
        }

        public Laite(int tuotenro, string tuotenimi)
        {
            Tuotenro = tuotenro;
            Tuotenimi = tuotenimi;
        }

        public override string ToString()
        {
            string tuote =  $"Tuotekoodi: {Tuotenro}\nNimi: {Tuotenimi}\nValmistusmaa: {Valmistusmaa}\n" +
                $"Pakkausksen koko:  {leveys} cm x {korkeus} cm x {syvyys} cm\nPakkauksen tilavuus: {leveys*korkeus*syvyys/1000000.0} m3\n";
            return tuote;
        }

    }
}
