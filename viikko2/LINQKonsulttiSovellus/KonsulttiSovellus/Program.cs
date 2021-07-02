using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace KonsulttiSovellus
{
    class Program
    {
        static void Main(string[] args)
        {


                  List<string> konsultit = new List<string>() {
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

            var etunimenMukaanJärjestykseen = from n in konsultit
                                              orderby n
                                              select n;
            foreach (var item in etunimenMukaanJärjestykseen)
            {
                Console.WriteLine(item);
            }

            List<Konsultti> konsulttiLista = new List<Konsultti>();

            foreach (var n in konsultit)
            {
                string[] nimenosat = n.Split(' ');
                Konsultti k = new Konsultti(nimenosat[0], nimenosat[1]);
                konsulttiLista.Add(k);
            }

            var sukunimenMukaanJärjestykseen = from n in konsulttiLista
                                               orderby n.Sukunimi
                                               select n;
            Console.WriteLine();
            foreach (var item in sukunimenMukaanJärjestykseen)
            {
                Console.WriteLine(item);
            }

            return;
        //Konsultti aku = new Konsultti() { Etunimi = "Aku", Sukunimi = "Ankka" };
        //XmlSerializer x = new XmlSerializer(typeof(Konsultti));
        //StreamWriter w = new StreamWriter("c:\\work\\academy4\\ankka.xml");
        ////w.WriteLine(aku);
        //x.Serialize(w, aku);
        //w.Close();

        //return;
        Campus c = new Campus();
            //c.ExtMetDemo();
            c.LINQbyExtensionMethods();


            //1. tulosta ne konsultit joiden nimessä on "nen" ja sitten ne 
            // joiden nimestä puuttuu "nen"
            var q1 = from k in c.Konsultit
                     where k.Sukunimi.ToLower().Contains("nen")
                     select k;

            var q1_2 = c.Konsultit.Where(k => k.Sukunimi.Contains("nen"));

            var qYksJaPuoli = from k in c.Konsultit
                              where !k.Sukunimi.Contains("nen")
                              select k;
            TulostaKonsolille(q1, "sukunimi sisältää nen");
            TulostaKonsolille(qYksJaPuoli, "nen puuttuu");

            TulostusToiminto(q1);

            //2. tulosta konsultit sukunimen mukaan aakkosjärjestyksessä
            var q2 = from k in c.Konsultit
                     orderby k.Sukunimi ascending
                     select k;
            TulostaKonsolille(q2, "Sukunimen mukaan järjestyksessä");

            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }

            //3. tulosta konsultit etunimen mukaan takaperoisessa aakkosjärjestyksessä
            var q3 = from k in c.Konsultit
                     orderby k.Etunimi descending
                     select k;
            TulostaKonsolille(q3, "etunimen mukaan käänteisessä järjestyksessä");

            //4. tulosta konsultin tiedot jonka etunimen ja sukunimen yhteenlaskettu pituus on suurin
            var q4 = from k in c.Konsultit
                     orderby k.Etunimi.Length + k.Sukunimi.Length descending
                     select k;
            Console.WriteLine(q4.First());

            //5. tulosta konsultin tiedot jonka sukunimessä on vähiten vokaaleja
            var q5 = from k in c.Konsultit
                     orderby k.Sukunimi.VokaaliLkm()
                     //orderby VokaalienLukuMäärä( k.Sukunimi)
                     select k;
            q5 = from k in c.Konsultit
                 orderby ((from c in k.Sukunimi where "aeiouyåäö".Contains(c) select c).Count())
                 select k;
            Console.WriteLine(q5.First());

            //6. hae kaikki konsultit ja muodosta niistä uusi anonyymiluokka jossa on nimi ja nimen pituus, nimi muodossa Sukunimi, Etunimi ja tulosta konsolille
            var q6 = from k in c.Konsultit
                     select new
                     {
                         Nimi = $"{k.Sukunimi}, {k.Etunimi}",
                         Pituus = k.Etunimi.Length + k.Sukunimi.Length
                     };
            Console.WriteLine("Anonyymiluokka");
            foreach (var item in q6)
            {
                Console.WriteLine(item);
            }
            //7. kokeile onnistutko kirjoittamaan kyselyt Extension Methods –muotoon ?



            //Konsultti k = c.Konsultit.Max();
            //string nimi = "Aku         Ankka     Ankkalinna     313";
            //nimi = nimi.BlankkoTrimmaus();
            //Console.WriteLine(nimi);
            //nimi = nimi.Replace('x', "poks");
            //c.TulostaKonsultitAakkosjärjestyksessä(true);
            //Console.WriteLine();
            //c.TulostaKonsultitAakkosjärjestyksessä(false);
        }

        private static object VokaalienLukuMäärä(string nimi)
        {
            return nimi.ToLower().Count(c => "aeiouyöäå".IndexOf(c) != -1);
        }

        private static void TulostusToiminto(IEnumerable<Konsultti> q1)
        {
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }
        }

        private static void TulostaKonsolille(IEnumerable<Konsultti> q1, string otsikko = null)
        {
            Console.WriteLine();
            Console.WriteLine(otsikko ?? "==================");
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
