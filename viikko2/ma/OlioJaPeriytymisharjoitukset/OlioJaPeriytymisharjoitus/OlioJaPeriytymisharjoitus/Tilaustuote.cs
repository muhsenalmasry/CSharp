using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioJaPeriytymisharjoitus
{
    class Tilaustuote : Tuote
    {
        private const decimal VakioTilausMaksu = 25M;
        public decimal Tilauskulut { get; set; }
        public Tilaustuote(int nro, string nimi, decimal hinta) : base()
        {
            Tuotenumero = nro;
            Nimi = nimi;
            Hinta = hinta;
            Tilauskulut = VakioTilausMaksu;
        }
        public Tilaustuote(int nro, string nimi, decimal hinta, decimal kulut)
        {
            Tuotenumero = nro;
            Nimi = nimi;
            Hinta = hinta;
            Tilauskulut = kulut;
        }
        public override decimal LaskeHinta()
        {
            Hinta += Tilauskulut;
            return Hinta;
        }
        public override string ToString()
        {
            return String.Format("Tuotenumero: {0}, Tuotenimi: {1}, TilausHinta: {2}", Tuotenumero, Nimi, LaskeHinta());
        }
    }
}
