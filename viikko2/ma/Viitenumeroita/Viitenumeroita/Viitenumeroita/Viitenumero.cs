using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viitenumeroita
{
    class Viitenumero
    {
        public static string Laskeviite(string nro)
        {
            string n;
            int summa = 0;
            int painoarvo = 7;
            for (int i = nro.Length-1; i >= 0; i--)
            {
                n = nro.Substring(i, 1);
                summa += int.Parse(n) * painoarvo;
                painoarvo /= 2;
                if (painoarvo < 1)
                    painoarvo = 7;
            }

            int tarkiste = ((summa / 10) + 1) * 10 - summa;
            return nro + tarkiste;
        }

        public static string Laskeviite(string nro, int kasvatusnro, int tulostusmäärä)
        {
            string n;
            int summa = 0;
            int painoarvo = 7;
            string viitteet = "";
            for (int i = 0; i < tulostusmäärä; i++)
            {
                viitteet += "Viitenumero " + i + ": " + Laskeviite(nro) + "\n";
                nro = Convert.ToString(int.Parse(nro) + kasvatusnro);
            }
            return viitteet;
        }
    }
}
