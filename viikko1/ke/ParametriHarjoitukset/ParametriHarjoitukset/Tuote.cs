using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametriHarjoitukset
{
    public class Tuote
    {
        public int Tuotenumero { get; set; }
        public string Tuotenimi { get; set; }
        public string Kuvaus { get; set; }
        public double Hinta { get; set; }

        public Tuote()
        {
            
        }
        public Tuote(int tuotenumero, string tuotenimi, double hinta)
        {
            Tuotenumero = tuotenumero;
            Tuotenimi = tuotenimi;
            Hinta = hinta;
        }
        public Tuote (int tuotenumero, string tuotenimi, string kuvaus, double hinta)
        {
            Tuotenumero = tuotenumero;
            Tuotenimi = tuotenimi;
            Kuvaus = kuvaus;
            Hinta = hinta;
        }
    }
}
