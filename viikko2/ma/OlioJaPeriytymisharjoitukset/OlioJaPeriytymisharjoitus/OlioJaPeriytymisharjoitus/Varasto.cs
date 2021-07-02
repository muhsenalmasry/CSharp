using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioJaPeriytymisharjoitus
{
    class Varasto
    {
        private Dictionary<string, Tuote> luokitellut;
        public List<Tuote> Tuotteet { get; private set; }
        public string VarastonNimi { get; set; }
        public Varasto(string nimi)
        {
            VarastonNimi = nimi;
            Tuotteet = new List<Tuote>();
            luokitellut = new Dictionary<string, Tuote>();
            var sth = from t in Tuotteet
                      where t.Hinta > 88
                      orderby t.Hinta
                      select t;
        }
        public void LisääTuote(Tuote tuote)
        {
            Tuotteet.Add(tuote);
        }
        public bool PoistaTuote(int tuotenro)
        {
            for (int i = 0; i < Tuotteet.Count; i++)
            {
                if (Tuotteet[i].Tuotenumero == tuotenro)
                {
                    Tuotteet.RemoveAt(i);
                    return true;
                } 
            }
            return false;
        }

        public bool PoistaTuote(Tuote t)
        {
            for (int i = 0; i < Tuotteet.Count; i++)
            {
                if(t.Nimi.Equals(Tuotteet[i].Nimi) && t.Tuotenumero == Tuotteet[i].Tuotenumero)
                {
                    Tuotteet.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public decimal VarastonArvo()
        {
            decimal varastonArvo = 0M;
            for (int i = 0; i < Tuotteet.Count; i++)
            {
                varastonArvo += Tuotteet[i].Hinta;
            }
            return varastonArvo;
        }
        public void PävitäPerusluokitus()
        {
            Tuote kallein = Tuotteet[0];
            Tuote halvin = Tuotteet[0];
            for (int i = 1; i < Tuotteet.Count; i++)
            {
                if (kallein.Hinta < Tuotteet[i].Hinta)
                    kallein = Tuotteet[i];
                if (halvin.Hinta > Tuotteet[i].Hinta)
                    halvin = Tuotteet[i];
            }
            luokitellut.Add("Kallein", kallein);
            luokitellut.Add("Halvin", halvin);
        }
        public Tuote LuokiteltuTuote(string luokitus)
        {
            if (luokitellut.ContainsKey(luokitus))
            {
                luokitellut.TryGetValue(luokitus, out Tuote tuote);
                return tuote;
            }
            return null;
        }
    }
}
