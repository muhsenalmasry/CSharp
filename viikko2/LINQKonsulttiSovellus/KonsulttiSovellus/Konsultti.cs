using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace KonsulttiSovellus
{

    public class Konsultti
    {
        public string Etunimi { get; set; }

        public string Sukunimi { get; set; }

        public Konsultti(string etunimi = null, string sukunimi = null)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
        }

        public override string ToString()
        {
            return $"{Sukunimi}, {Etunimi}";
        }
    }
}
