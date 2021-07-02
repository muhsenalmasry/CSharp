using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametriHarjoitukset
{
    public class Testipenkki
    {
        public Testipenkki()
        {

        }
        public string NimiKuntoon(string etunimi, string sukunimi)
        {
            etunimi = etunimi.Substring(0, 1).ToUpper() + etunimi.Substring(1,etunimi.Length-1).ToLower();
            sukunimi = sukunimi.Substring(0, 1).ToUpper() + sukunimi.Substring(1, sukunimi.Length - 1).ToLower();
            return sukunimi + ", " + etunimi;
        }

        public string NimiKuntoon(string nimi)
        {
            string[] nimet = nimi.Split(" ");
            string etunimi = nimet[0];
            string sukunimi = nimet[1];
            return NimiKuntoon(etunimi, sukunimi);
        }

        
        public bool TarkistaTuote(Tuote t, out string virheet, out string varoitukset)
        {
            virheet = "Virhe! ";
            varoitukset = "Varoitus! ";
            bool ok = true;
            if (t.Tuotenumero<1000 || t.Tuotenumero > 9999)
            {
                varoitukset = "VAROITUS! Tuotenumero on oltava [1000,9999] välillä. ";
                ok = false;
            }
            if(t.Tuotenimi.Length < 5 || t.Tuotenimi.Length > 30)
            {
                virheet += "Tuotenimen pituus on oltava 5-30 merkin pituinen. ";
                ok = false;
            }
            if (String.IsNullOrEmpty(t.Kuvaus))
            {
                varoitukset += "Kuvaus puuttuu. ";
                ok = false;
            }
            if(t.Hinta < 0.01 || t.Hinta > 999.99)
            {
                virheet += "Tuotteen hinta on oltava 0.01-999.99 vlälillä. ";
                ok = false;
            }

            return ok;
        }

        public int LaskeYhteen(params int[] luvut)
        {
            int sum = 0;
            for (int i = 0; i < luvut.Length; i++)
            {
                sum += luvut[i];
            }
            return sum;
        }

        public string [] TeeTaulukko(params string[] nimet)
        {
            string[] nimiTaulukko = new string[nimet.Length];
            for (int i = 0; i < nimet.Length; i++)
            {
                nimiTaulukko[i] = nimet[i];
            }
            Array.Sort(nimiTaulukko);
            return nimiTaulukko;
        }
    }
}
