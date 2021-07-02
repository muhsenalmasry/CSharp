using System;
using System.Collections.Generic;

namespace Ke_LisäHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            int alku = 1, loppu = 10;
            Tulostukset t = new Tulostukset();
            t.TulostaLuvut(alku, loppu);

            
            List<string> kysely = new List<string> { "Onko C# mainio?", "Osaatko käyttää Snippettejä?", "Onko kurssilla taukoja tarpeeksi usein ja riittävän pitkiä?", "Onko tänään hyvä päivä?" };
            t.TulostaKysely2(kysely);
        }
    }
}
