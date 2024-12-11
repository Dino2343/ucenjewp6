using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08WhilePetlja
    {
        public static void Izvedi()

        {
            int brojDo = 0;

            for (int t = 0; t < brojDo; t++)
            {



                Console.WriteLine(t);
            }
            while (true)
            {
                Console.WriteLine("Osijek");
                break;
            }

            int broj = 0, i = 2;
            while (broj < 10 && i == 2)
            {
                Console.WriteLine(++broj);
            }
            broj = 10;
            while (broj < 10)
            {
                Console.WriteLine(++broj);
            }


            int suma = 0;
            broj = 1;
            while(broj<=100)
            {
                suma += broj++;
                
               
            }
            Console.WriteLine(suma);




        }
    }
}
