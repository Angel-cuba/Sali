using System;
using System.Collections.Generic;
using System.Text;

// Ulkoinen nimiavaruus Henkilosto
namespace Henkilosto
{
    // Trainer-luokka perii Henkilo-luokan ominaisuudet, huom Henkilö Sali3-nimiavaruudessa
    class Trainer : Sali3.Henkilo
    {
        protected string ala;
        protected string puhelin;
        protected string email;

        // Muodostin kaikilla parametreilla
        public Trainer(string etu, string suku, string katu, string pnro, string paikka, string ala, string puh, string email)
        {
            this.etunimi = etu;
            this.sukunimi = suku;
            this.katuosoite = katu;
            this.postinumero = pnro;
            this.postitoimipaikka = paikka;
            this.ala = ala;
            this.puhelin = puh;
            this.email = email;
        }

        // Testausmetodi, joka näyttää tiedot
        public void naytaTrainer()
        {
            Console.WriteLine("Etunimi on " + this.etunimi);
            Console.WriteLine("Sukunimi on " + this.sukunimi);
            Console.WriteLine("Katuosoite on " + this.katuosoite);
            Console.WriteLine("Postinumero on " + this.postinumero);
            Console.WriteLine("Postitoimipaikka on " + this.postitoimipaikka);
            Console.WriteLine("Ala on " + this.ala);
            Console.WriteLine("Puhelin on " + this.puhelin);
            Console.WriteLine("Sähköposti on " + this.email);
        }
    }
}