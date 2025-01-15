using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E17KlasaObjekt.eunova;

namespace Ucenje.E18NasljedivanjePolimorfizam
{
    public class Program
    {
        //Konstruktor 
        public Program(string s)
        {
            Console.WriteLine("E18");
            var smjer = new Smjer() { Sifra = 1, Naziv = "Web Programiranje" };
            Console.WriteLine(smjer);

            var osoba = new Osoba() { Sifra = 1, Ime = "Pero", Prezime = "Peric" };
            osoba = new Osoba("Marija", "Zimska");

            //sring je imutible
            string s1 = "AA";
            Console.WriteLine(s1.GetHashCode());
            s1 = "BB";
            Console.WriteLine(s1.GetHashCode());
            //dosadasnja praksa spajanja stringova  s plus nije dobra
            // dobra praksa je korisritu string builder 

            var sb= new StringBuilder();
            sb.Append("AA");
            Console.WriteLine(sb.GetHashCode());
            sb.Clear().Append("BB");
            Console.WriteLine(sb.GetHashCode());

            Smjer smjer1 = new Smjer() { Naziv = "Web programiranje" };
            Smjer smjer2 = new Smjer() { Naziv = "Web programiranje" };


            Console.WriteLine(smjer1.GetHashCode());
            Console.WriteLine(smjer2.GetHashCode());


            Console.WriteLine(smjer.Equals(smjer2));

            //var e = new Entitet();
            //e.Sifra = 1;
            var e = new Entitetimpl() { Sifra = 1 };

            //jos nismo na polimorfizmu

            Obrada[] obrade = new Obrada[2];

            obrade[0] = new ObradaUlazniRacun();
            obrade[1] = new ObradaIzlazniRacun();

            //Polimorfizam
            foreach (Obrada o in obrade)
            {
                o.Procesuiraj();
            }

        }
    }
}
