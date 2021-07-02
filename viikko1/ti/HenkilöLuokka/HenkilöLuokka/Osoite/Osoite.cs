using System;

namespace Osoitteet
{
    public class Osoite
    {
        public string Kotiosoite { get; }
        public string Postitoimipaikka { get; }
        public int Postinumero { get; }
        public string Toimitusosoite { get; }
        public string TPostitoimipaikka { get; }
        public int TPostinumero { get; }

        public Osoite(string kotiosoite, string postitoimipaikka, int postinumero)
        {
            Kotiosoite = kotiosoite;
            Postitoimipaikka = postitoimipaikka;
            Postinumero = postinumero;
            Toimitusosoite = kotiosoite;
            TPostitoimipaikka = postitoimipaikka;
            TPostinumero = postinumero;
        }

        public Osoite (string kotiosoite, string postitoimipaikka, int postinumero,
            string toimitusosoite, string tPostitoimipaikka, int tPostinumero)
        {
            Kotiosoite = kotiosoite;
            Postitoimipaikka = postitoimipaikka;
            Postinumero = postinumero;
            Toimitusosoite = toimitusosoite;
            TPostitoimipaikka = tPostitoimipaikka;
            TPostinumero = tPostinumero;
        }

        public override string ToString()
        {
            string osoite = "Kotiosoite:\n" + Kotiosoite + "\n" + Postitoimipaikka + "\n" + Postinumero + "\nToimitusosoite:\n" + Toimitusosoite + "\n" + TPostitoimipaikka + "\n" + Postinumero;
            return osoite;
        }
    }
}
