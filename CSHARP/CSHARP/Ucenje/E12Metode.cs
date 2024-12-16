using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Metode
    {
        public static void Izvedi()
        {
            Tip1();
            Tip1();
            Tip2(7);
            Tip2(5);

            Tip2(10,"Poziv druge varijante metode Tip2");

            int i = Tip3() + 1;
            Console.WriteLine(i);
            int[] niz = { 2, 4, 4, 3, 1, 2, 3, 4, 6 };
            Console.WriteLine(Tip4(niz));
            Tip4(niz);  // ona ce se izvesti ali nijedan rezultat nema efekta u ovoj metodi 
            
        }


        //tijelo metode 
        //Tip1: Ne prima parametre ne vraca vrijednosti 
        static void Tip1() 
        {
            Console.WriteLine("ispis iz prvog tipa metode");
            Console.WriteLine("************");
            Console.WriteLine("Kraj ispisa iz 1. tipa metode");
        }
        // prima parametre ali ne vraca vrijednosti 
        private static void Tip2(int x)  //x je parametar tipa int 

        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }

        }
        //potpis metode 
        //naziv + lista parametara 
        private static void Tip2(int x,string naslov)
        {
            Console.WriteLine(naslov);
            Tip2(x);
        }
        //ne prima parametre ali vraca vrijednost
        private static int Tip3()
        {
            return int.MaxValue; //svaka metoda od tipa koji nije void mora imati return
        }


        // tip4 prima parametre i vraca vrijednost 
        /// <summary>
        /// Metoda ce zaprimljeni niz cijelih brojeva vratiti sumu 
        /// </summary>
        /// <param name="niz">Niz cijelih brojeva</param>
        /// <returns>Suma primljenih nizova</returns>
        private static int Tip4(int[]niz)
        {
            int suma = 0;   
            foreach(int i in niz)
            {
                suma += i;
            }
            return suma;
        }
        // nama bitne metode 
        // write once,use everywhere
        public static int UcitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.WriteLine(poruka);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Problem kod ucitanja broja !!!!!!!");
                 
                }
            }


            //return 0; // kasnije obrisati 
        }
    }
}
