using System;
using Osoitteet;

namespace HenkilöLuokka
{
    public class Henkilö
    {
        private readonly int _id;
        private static int seuraavaVapaaId = 1;
        private string Etunimi { get; }
        private string Sukunimi { get; }
        private int Ikä { get; }
        public int Id { get; set;}
        private Osoite Osoite { get; }

        public Henkilö()
        {

        }

        public Henkilö(string etunimi, string sukunimi, int ikä)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Ikä = ikä;
            Id = seuraavaVapaaId;
            seuraavaVapaaId ++;
        }

        public Henkilö(string etunimi, string sukunimi, int ikä, string kotiosoite, string postitoimipaikka, int postinumero)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Ikä = ikä;
            Osoite = new Osoite(kotiosoite, postitoimipaikka, postinumero);
        }

        public Henkilö(string etunimi, string sukunimi, int ikä, string kotiosoite, string postitoimipaikka, int postinumero,
            string toimitusosoite, string tPostitoimipaikka, int tPostinumero)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Ikä = ikä;
            Osoite = new Osoite(kotiosoite, postitoimipaikka, postinumero, toimitusosoite, tPostitoimipaikka, tPostinumero);
        }

        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + ", " + Ikä + " vuotta." + "ID: " + Id;
        }
    }
}
