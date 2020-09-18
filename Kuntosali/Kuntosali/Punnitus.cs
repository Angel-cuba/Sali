using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sali3
{
    class Punnitus
    {
        //  Kaikki kentät merkkijonoja, koska syöte tulee näppäimistöstä
        protected string paiva;
        protected string paino;
        protected string pituus;

        // Muodostin kaikilla parametreilla
        public Punnitus(string paiva, string paino, string pituus)
        {
            this.paiva = paiva;
            this.paino = paino;
            this.pituus = pituus;
        }

        public float BMI()
        {
            // Muutetaan olion merkkijono-ominaisuudet liukuluvuiksi
            float paino = float.Parse(this.paino);
            float pituus = float.Parse(this.pituus);

            // Lasketaan painoindeksi ja palautetaan se
            float bmi = paino / (pituus * pituus);
            return bmi;
        }
        // Testausmetodi punnitustietojen näyttämiseen
        public void naytaPunnitus()
        {
            Console.WriteLine("Punnituspäivä: " + this.paiva);
            Console.WriteLine("Paino: " + this.paino);
            Console.WriteLine("Pituus: " + this.pituus);
        }
    }
}