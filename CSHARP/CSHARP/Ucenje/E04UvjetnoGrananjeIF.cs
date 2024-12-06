using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04UvjetnoGrananjeIF
    {
        public static void Izvedi()
        {
            // Console.WriteLine("E04");

            int i = 0;
            bool uvijet = i == 0;
            Console.WriteLine(uvijet);

            if (uvijet)
            {
                Console.WriteLine("Vrijednost varijable i je 0");

            }
            if (i == 0)
            {
                Console.WriteLine("Češća sintaksa");

            }


            if (i >= 17)
            {
                Console.WriteLine("Punoljetna osoba");
            }
            else
            {
                Console.WriteLine("Maloljetna osoba");



            }


            if (i > 5)
                Console.WriteLine("ok");
            else
                Console.WriteLine("Greska");
            Console.WriteLine("Dio greške");

            // & i &&

            int j = 2;
            if (i == 5 & j == 2)
            {
                Console.WriteLine("Dvostruki uvijet je zadovoljen");
            }
            if (i == 5 && j == 2)
            {
                Console.WriteLine("Dvostruki uvijet zadovoljen");

            }
            if (i == 0 | j == 0)
            {
                Console.WriteLine("Prvi uvijet je zadovoljen");
            }
            if (i == 0 || j == 0) ;
            {
                Console.WriteLine("Prvi uvijet je zadoboljen");
            }
            if (i > 0)
            {
                if (j > 0)
                {
                    Console.WriteLine("Ugnjeznjavanje");

                }
            }
            i = 2;
            if (i == 0)
            {
                Console.WriteLine("Nula");

            }
            else if (i == 1)
            {
                Console.WriteLine("Jedan");
            }
            else
            {
                Console.WriteLine("Ostali brojevi");
            }
            string grad = "Osijek";
            if (grad == "Osijek")
            {
                Console.WriteLine("Super");
            }
            else
            {
                Console.WriteLine("Nije super");
            }


            Console.WriteLine(grad == "Osijek" ? "Super" : "Nije super");
            Console.WriteLine((grad == "Osijek" ? "" : "Nije ") + "Super");
        }    



    }
}
