using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E17KlasaObjekt.eunova;

namespace Ucenje.E17KlasaObjekt
{
    internal class Program
    {
        // 5. vrsta metode Konstruktor
        //konstruktor mora imati isti naziv kao i klasa a lista parametara moze biti razliciti
        public Program()
        {
            //Objekt je instanca (Pojvnost) klase

            //Osoba je ime klasa(primjeniti veliko pocetno slovo)
            //osoba je objekt (Instance) -varijabla (primjeniti malo pocentno slovo)

            Osoba osoba = new Osoba();

            osoba.Sifra = 1;

            osoba.Ime = "Pero";
            osoba.Prezime = "Perić";
            Console.WriteLine(osoba.Ime);

            osoba = new Osoba()
            {
                Sifra = 2,
                Ime = "Karlo",
                Prezime = "Lik"
            };
            Console.WriteLine("{0} {1}",osoba.Ime,osoba.Prezime);
            Console.WriteLine(osoba.ImePrezime());

            Osoba.Izvedi();

            Mjesto mjesto = new Mjesto() { Naziv = "Osijek", PostanskiBroj = "31000" };
            osoba.Mjesto=mjesto;

            Console.WriteLine(osoba.Mjesto.Naziv);

            osoba.Mjesto = new Mjesto() { Naziv = "Osijek" };
            Console.WriteLine(osoba.Mjesto.Zupanija?.Zupan ?? "Prazno");


            Smjer smjer = new Smjer() { Naziv = "Web programieranje" };
            Grupa grupa = new () {Naziv="WP6",Smjer=smjer};
            Polaznik[] PolazniciNiz = new Polaznik[2];

            PolazniciNiz[0] = new Polaznik() { Ime = "Pero" };
            PolazniciNiz[1] = new Polaznik() { Ime = "Marija" };

            grupa.Polaznici=PolazniciNiz;


            //ispisati podatke o grupi
            Console.WriteLine(grupa.Naziv );
            Console.WriteLine(grupa.Smjer.Naziv);
            foreach(Polaznik p in grupa.Polaznici)
            {
                Console.WriteLine("{0} {1}",p.Ime , p.Prezime);
            }
            Console.WriteLine("???????????????????");
            grupa.DetaljiGrupe();







        }
    }
}
