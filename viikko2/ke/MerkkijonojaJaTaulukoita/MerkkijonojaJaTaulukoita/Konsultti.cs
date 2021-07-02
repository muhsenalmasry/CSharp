using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerkkijonojaJaTaulukoita
{
    public class Konsultti
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public Konsultti(string etunimi, string sukunimi)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
        }
        public override string ToString()
        {
            return Etunimi + ", " + Sukunimi;
        }
    }
}
