using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    class Rasvaprosentti
    {
        // Määritellään kentät (field), huom. nimi pienellä
        protected string sukupuoli;
        protected string ika;

        // Samat tiedot ominaisuuksina (property), huom nimi isolla
        public string Sukupuoli
        {
            get
            { return sukupuoli; }
            set
            { sukupuoli = value; }
        }

        public string Ika
        {
            get
            { return ika; }
            set
            { ika = value; }
        }

        // Sama voitaisiin tehdä lyhyemmin
        public string Vuotta { get; set; }
        public string Spuoli { get; set; }

        // Ominaisuus voidaan myös tehdä sellaiseksi, että sitä voi vain lukea, muttei muuttaa
        public string VuottaVanha { get; }

        // Ominaisuus voidaan myös määritellä vain muokattavaksi
#pragma warning disable CS8051 // Auto-implemented properties must have get accessors.
        public string Sukup { set; get; }
#pragma warning restore CS8051 // Auto-implemented properties must have get accessors.

        // Oletusmuodostin
        public Rasvaprosentti()
        {
            this.sukupuoli = "Nainen";
            this.ika = "0";
        }

        // Muodostin kaikilla parametreillä
        public Rasvaprosentti(string sukupuoli, string ika)
        {
            this.sukupuoli = sukupuoli;
            this.ika = ika;
        }

        public float laskeRasva(float pituus, float paino)
        {
            float bmi = paino / (pituus * pituus);
            float sukupuolikerroin = 0;
            if (this.sukupuoli == "Mies")
            {
                sukupuolikerroin = 1;
            }

            float rasva = (1.2f * bmi) + (0.23f * float.Parse(this.ika)) - (10.8f * sukupuolikerroin) - 5.4f;
            return rasva;
        }

        // Staattinen metodi, jolla rasvaprosentti voidaan laskea luomatta oliota
        static public float laskeRasva2(float paino, float pituus, float ika, string sukupuoli)
        {
            float bmi = paino / (pituus * pituus);
            float sukupuolikerroin = 0;
            sukupuoli = sukupuoli.ToLower();
            if (sukupuoli == "mies")
            {
                sukupuolikerroin = 1;
            }
            float rasva = (1.2f * bmi) + (0.23f * ika) - (10.8f * sukupuolikerroin) - 5.4f;
            return rasva;
        }
    }
}