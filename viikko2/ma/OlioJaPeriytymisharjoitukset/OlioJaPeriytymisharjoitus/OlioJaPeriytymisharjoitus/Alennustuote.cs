using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioJaPeriytymisharjoitus
{
    public class Alennustuote : Tuote , IAlennus
    {
        public float Alennusprosentti { get; set; }
        public Alennustuote(int nro, string nimi, decimal hinta, float ale) : base()
        {
            Tuotenumero = nro;
            Nimi = nimi;
            Hinta = hinta;
            Alennusprosentti = ale;
        }
        public override decimal LaskeHinta()
        {
            return Hinta * (decimal)Alennusprosentti / 100;
        }
        public void LisääAlennus(float prosenttia)
        {
            Alennusprosentti += prosenttia;
            Hinta = Hinta * (decimal)Alennusprosentti / 100;
        }
        public void MuutaAlennus(float alkuperäinen, float uusiAlennus)
        {
            if(Alennusprosentti == alkuperäinen)
            {
                Alennusprosentti = uusiAlennus;
            }
        }
        public override string ToString()
        {
            return String.Format("Tuotenumero: {0}, Tuotenimi: {1}, Alennushinta: {2}", Tuotenumero, Nimi, LaskeHinta());
        }
    }
}
