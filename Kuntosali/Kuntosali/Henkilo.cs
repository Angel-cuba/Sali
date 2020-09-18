using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    class Henkilo
    {
        // Määritellään kaikkien henkilöiden yhteiset ominaisuudet (kentät)
        // Jäsen-luokka perii nämä ominaisuudet
        protected string etunimi;
        protected string sukunimi;
        protected string katuosoite;
        protected string postinumero;
        protected string postitoimipaikka;

        // Olionmuodostimet (konstruktorit)

        // Oletusmuodostin
        public Henkilo()
        {
            this.etunimi = "etunimi";
            this.sukunimi = "sukunimi";
            this.katuosoite = "N/A";
            this.postinumero = "N/A";
            this.postitoimipaikka = "N/A";
        }
        // Muodostin kaikilla parametreilla
        public Henkilo(string etu, string suku, string katu, string pnro, string paikka)
        {
            this.etunimi = etu;
            this.sukunimi = suku;
            this.katuosoite = katu;
            this.postinumero = pnro;
            this.postitoimipaikka = paikka;
        }

        // Metodeja testaukseen
        public void naytaHenkilo()
        {
            Console.WriteLine("Etunimi on " + this.etunimi);
            Console.WriteLine("Sukunimi on " + this.sukunimi);
            Console.WriteLine("Katuosoite on " + this.katuosoite);
            Console.WriteLine("Postinumero on " + this.postinumero);
            Console.WriteLine("Postitoimipaikka on " + this.postitoimipaikka);
        }
    }
    class Jasen : Henkilo
    {
        // Jäsen-olioiden erityisominaisuudet, joita ei ole Henkilo-luokassa
        protected string jasenid;
        protected string sukupuoli;

        // Muodostin kaikilla parametreillä
        public Jasen(string etu, string suku, string katu, string pnro, string paikka, string id, string sukup)
        {
            this.etunimi = etu;
            this.sukunimi = suku;
            this.katuosoite = katu;
            this.postinumero = pnro;
            this.postitoimipaikka = paikka;
            this.jasenid = id;
            this.sukupuoli = sukup;
        }

        // Metodeja testaukseen
        public void naytaJasen()
        {
            Console.WriteLine("Etunimi on " + this.etunimi);
            Console.WriteLine("Sukunimi on " + this.sukunimi);
            Console.WriteLine("Katuosoite on " + this.katuosoite);
            Console.WriteLine("Postinumero on " + this.postinumero);
            Console.WriteLine("Postitoimipaikka on " + this.postitoimipaikka);
            Console.WriteLine("Jäsennumero on " + this.jasenid);
            Console.WriteLine("Sukupuoli on " + this.sukupuoli);
        }
    }
}