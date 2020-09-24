using System;

namespace Sali3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testataan Henkilo-olion luontia");

            /****************************************************
             * TESTAUS ALKAA TÄSTÄ                              *
             ****************************************************/

            // Testataan oletusmuodostin

            Henkilo henkilo = new Henkilo();

            // Testataan muodostin kaikilla parametreillä

            Henkilo henkilo1 = new Henkilo("Mika", "Hakala", "Kotikatu 3", "20100", "Turku");

            // Testataan Jäsen-olion muodostimen toiminta
            Jasen jasen = new Jasen("Mika", "Vainio", "Yläneentie 146", "23100", "Mynämäki", "123", "1", "26,1,1984");

            // Testatataan Punnitus-olion toimintaa
            Punnitus punnitus = new Punnitus("10.9.2020", "70,5", "1,71");

            // Katsotaan olioiden ominaisuuksia
            Console.WriteLine("Testi henkilön oletusmuodostimelle");
            henkilo.naytaHenkilo();
            Console.WriteLine("Testi henkilön muodostimelle kaikilla parametreilla");
            henkilo1.naytaHenkilo();
            Console.WriteLine("Testi jäsenen muodostimelle");
            jasen.naytaJasen();           
            Console.WriteLine("Testi punnituksen muodostimelle");
            punnitus.naytaPunnitus();

            // Testi iän laskennan toimimisesta
            int vuotta = Rasvaprosentti.Ika("26,1,1984");
            Console.WriteLine("Moon " + vuotta + " vuotta vanha");
            
        }
    }
}