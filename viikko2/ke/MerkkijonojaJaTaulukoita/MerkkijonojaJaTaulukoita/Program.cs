using System;
using System.Collections.Generic;
using System.Linq;

namespace MerkkijonojaJaTaulukoita
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] konsultit = {"Muhsen Almasry", "Juri Heiniluoma", "Heidi Vähätalo", "Niina Siitari", "Riku Soikkeli", "Ari Savolainen", "Jani Huusko", "Matias Vähäkangas",
                "Emma Saarelainen", "Marko Salmikangas", "Johanna Niklander ", "Janica Jokela", "Noora Lohi", "Thien Nguyen", "Otso Peippo", "Roope Rouvali" };
            //var q = from k in konsultit
            //        orderby k
            //        select k.Split(" ")[0];
            //Console.WriteLine(q.First());
            //Console.WriteLine(q.Last());

            //q = from k in konsultit
            //    orderby k.Split(" ")[1]
            //    select k.Split(" ")[1];
            //Console.WriteLine(q.First());
            //Console.WriteLine(q.Last());
            List<Konsultti> konsulttilista = new List<Konsultti>();
            foreach (var k in konsultit)
            {
                konsulttilista.Add(new Konsultti(k.Split(" ")[0], k.Split(" ")[1]));
            }

            //var q = from k in konsulttilista
            //        orderby k.Etunimi
            //        select k;
            //Console.WriteLine(q.First());

            //q = from k in konsulttilista
            //    orderby k.Sukunimi
            //    select k;
            //Console.WriteLine(q.Last());

            //Random rnd = new Random();
            //int ryhmäkoko = 5;
            //int ryhmienlkm = konsulttilista.Count / ryhmäkoko;
            //string ryhmät = "";
            //for (int i = 0; i < ryhmienlkm; i++)
            //{
            //    ryhmät += "Ryhmä " + (i + 1) + ":\n";
            //    for (int j = 0; j < ryhmäkoko; j++)
            //    {
            //        int index = rnd.Next(0, konsulttilista.Count - 1);
            //        ryhmät += konsulttilista[index] + "\n";
            //        konsulttilista.RemoveAt(index);
            //    }
            //    ryhmät += "\n";
            //}
            //Console.WriteLine(ryhmät);

            //SortedDictionary<int, Konsultti> sd = new SortedDictionary<int, Konsultti>();
            //ryhmienlkm = konsultit.Length / ryhmäkoko;
            //foreach (var k in konsulttilista)
            //{
            //    int key = rnd.Next(0, 1000);
            //    sd.Add(key, k);
            //}
            //foreach (var item in sd)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //foreach (var avain in sd.Keys)
            //{
            //    Konsultti kon = sd[avain];
            //}
            //string s = "tes ti mjo ,no.";
            //s = s.BlankkoTrimmaus();
            //Console.WriteLine("\n\n\n" + s + "\n");

            var q = from k in konsulttilista
                    where k.Sukunimi.Contains("nen")
                    select k;
            //foreach (var item in q)
            //{
            //    Console.WriteLine(item);
            //}

            //q = from k in konsulttilista
            //    orderby k.Sukunimi descending
            //    select k;
            //foreach (var item in q)
            //{
            //    Console.WriteLine(item);
            //}
            q = from k in konsulttilista
                orderby (k.Etunimi + k.Sukunimi).Length ascending
                select k;
            Console.WriteLine(q.Last());

            var  q2 = from k in konsulttilista
                 select new
                 {
                     Nimi = $"{k.Sukunimi}, {k.Etunimi}",
                     Pituus = k.Etunimi.Length + k.Sukunimi.Length
                 };
            Console.WriteLine("Anonyymiluokka");
            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
