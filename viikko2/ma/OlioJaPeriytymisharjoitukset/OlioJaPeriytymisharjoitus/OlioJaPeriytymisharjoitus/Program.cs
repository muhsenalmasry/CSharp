using System;

namespace OlioJaPeriytymisharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Varasto KeskusVarasto = new Varasto("KeskusVarasto");
            Tuote Jatkojohto = new Tuote(1001, "Jatkojohto", 100);
            Tuote Hiiri = new Tuote(1020, "Hiiri", 9.99M);
            Tuote Mukiteline = new Tuote(3010, "Mukiteline", 19.99M);
            KeskusVarasto.LisääTuote(Jatkojohto);
            KeskusVarasto.LisääTuote(Hiiri);
            KeskusVarasto.LisääTuote(Mukiteline);
            for (int i = 0; i < KeskusVarasto.Tuotteet.Count; i++)
            {
                Console.WriteLine(KeskusVarasto.Tuotteet[i]);
            }
            Console.WriteLine(KeskusVarasto.VarastonArvo());
            KeskusVarasto.PoistaTuote(1020);
            for (int i = 0; i < KeskusVarasto.Tuotteet.Count; i++)
            {
                Console.WriteLine(KeskusVarasto.Tuotteet[i]);
            }
            Alennustuote Tamagotchi = new Alennustuote(2345, "Tamagotchi", 100, 80.0f);
            KeskusVarasto.LisääTuote(Tamagotchi);
            foreach (var item in KeskusVarasto.Tuotteet)
            {
                Console.WriteLine(item);
            }
            Tilaustuote Kuulokkeet = new Tilaustuote(2542, "Kuulokkeet", 50);
            Tilaustuote Näyttö = new Tilaustuote(6237, "Näyttö", 230, 50);
            KeskusVarasto.LisääTuote(Kuulokkeet);
            KeskusVarasto.LisääTuote(Näyttö);
            foreach (var item in KeskusVarasto.Tuotteet)
            {
                Console.WriteLine(item);
            }
            Tuote Läppäri = new Tuote(2589, "Läppäri", 579, Verokanta.ALV_10);
            KeskusVarasto.LisääTuote(Läppäri);
            for (int i = 0; i < KeskusVarasto.Tuotteet.Count; i++)
            {
                Console.WriteLine(KeskusVarasto.Tuotteet[i]);
            }

            Console.WriteLine(KeskusVarasto.LuokiteltuTuote("Halvin"));
            KeskusVarasto.PävitäPerusluokitus();
            Console.WriteLine(KeskusVarasto.LuokiteltuTuote("Kallein"));
        }
    }
}
