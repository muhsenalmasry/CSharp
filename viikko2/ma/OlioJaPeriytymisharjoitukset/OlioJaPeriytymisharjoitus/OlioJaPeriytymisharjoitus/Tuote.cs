using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioJaPeriytymisharjoitus
{
    public class Tuote
    {
        private string nimi;
        private decimal hinta;
        Verokanta ALV { get; set; }
        public int Tuotenumero { get; set; }
        public string Nimi
        {
            get { return nimi; }
            set
            {
                if (value.Length >= 5)
                    nimi = value;
                else
                    throw new ArgumentException("Nimi liian lyhyt!");
            }
        }
        public decimal Hinta
        {
            get
            {
                return hinta;
            }
            set
            {
                if (value > 0)
                    hinta = value;
                else
                    throw new ArgumentException("Hinta liian pieni!");
            }
        }
        

        

        public Tuote()
        {

        }
        public Tuote(int tnro, string nimi, decimal hinta)
        {
            Tuotenumero = tnro;
            Nimi = nimi;
            Hinta = hinta;
            ALV = Verokanta.Yleinen24;
        }
        public Tuote(int tnro, string nimi, decimal hinta, Verokanta alv)
        {
            Tuotenumero = tnro;
            Nimi = nimi;
            Hinta = hinta;
            ALV = alv;
        }

        public virtual decimal LaskeHinta()
        {
            return Hinta + (decimal)ALV * Hinta / 100;
        }

        public override string ToString()
        {
            return String.Format("Tuotenumero: {0}, Tuotenimi: {1}, Hinta: {2}", Tuotenumero, Nimi, LaskeHinta());
        }
    }

    public enum Verokanta
    {
        Vapautus,
        ALV_0 = 0,
        ALV_10 = 10,
        ALV_14 = 14,
        Yleinen24 = 24,
    }
}
