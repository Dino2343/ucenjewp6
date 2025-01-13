using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{

    //Klasa je opisnik objekta 

    internal class Osoba
    {
        //klasa sadrzi svojstva 
        public int Sifra { get; set; } // OOP prinicip ucahurivanja
        public string? Ime { get; set; } // ? oznacava kako ime moze biti null
        public string? Prezime { get; set; } 
        public Mjesto? Mjesto { get; set; }

        //Klasa sadzi metode (ne moraju biti staticen)
        public string ImePrezime()
        {
            Console.WriteLine("Izvodenje metode s objekta");
            return Ime + " " + Prezime;
        }
        public static void Izvedi()
        {
            Console.WriteLine("Izvodenje metode klasae");
        }
    }
}
