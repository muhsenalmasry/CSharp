using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KonsulttiSovellus
{
    class Campus
    {
        private string[] konsultit = {
            "Muhsen Almasry",
            "Juri Heiniluoma",
            "Heidi Vähätalo",
            "Niina Siitari",
            "Riku Soikkeli",
            "Ari Savolainen",
            "Jani Huusko",
            "Matias Vähäkangas",
            "Emma Saarelainen",
            "Marko Salmikangas",
            "Johanna Niklander ",
            "Janica Jokela",
            "Noora Lohi",
            "Thien Nguyen",
            "Otso Peippo",
            "Roope Rouvali"
                    };

        public List<Konsultti> Konsultit { get; set; }

        public Campus()
        {
            Konsultit = TeeKonsulttiLista(konsultit);
        }

        private List<Konsultti> TeeKonsulttiLista(string[] konsultit)
        {
            List<Konsultti> kl = new List<Konsultti>();
            foreach (var s in konsultit)
            {
                string[] osat = s.Split(' ');
                kl.Add(new Konsultti() { Etunimi = osat[0], Sukunimi = osat[1] });
            }
            return kl;
        }

        public void TulostaKonsultitAakkosjärjestyksessä(bool sukuNimenMukaan = false)
        {
            Lajittele(konsultit, sukuNimenMukaan);
            Tulosta(konsultit);
        }

        private void Lajittele(string[] konsultit, bool sukunimi)
        {
            //Array.Sort(konsultit);
            // bubblesort eli kuplalajittelu
            for (int i = konsultit.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (parsiNimenOsa(konsultit[j], sukunimi).CompareTo(parsiNimenOsa(konsultit[j - 1], sukunimi)) < 0)
                    {
                        string temp = konsultit[j];
                        konsultit[j] = konsultit[j - 1];
                        konsultit[j - 1] = temp;
                    }
                }
            }
        }

        private string parsiNimenOsa(string nimi, bool sukunimi)
        {
            if (!sukunimi)
            {
                return nimi;
            }
            string[] osat = nimi.Split(' ');
            if (osat.Length == 0)
            {
                return "";
            }
            if (osat.Length == 1)
            {
                return nimi;
            }
            return osat[1] + " " + osat[0];
        }

        private void Tulosta(string[] konsultit)
        {
            foreach (var k in konsultit)
            {
                Console.WriteLine(k);
            }
        }

        public void ExtMetDemo()
        {
            Konsultti k = Konsultit[4];
            int indeksi = LaajennosDemot.LaskeIndeksi(k);
            indeksi = k.LaskeIndeksi();
            Console.WriteLine(indeksi);

            string merkkijono = "Aku    Ankka";
            Console.WriteLine("Alkutilanne: " + merkkijono);
            merkkijono = merkkijono.BlankkoTrimmaus();
            Console.WriteLine("Lopputulos: " + merkkijono);

        }

        public void LINQbyExtensionMethods()
        {
            string suurinKonsultti = konsultit.Max();
            int maxNimenpituus = Konsultit.Max(KonsultinKoonPalauttavaMetodi);
            maxNimenpituus = Konsultit.Max(k => k.Sukunimi.Length + k.Etunimi.Length);
        }

        int KonsultinKoonPalauttavaMetodi(Konsultti k)
        {
            return k.Sukunimi.Length + k.Etunimi.Length;
        }



    }
}
