using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10Z1
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi izraz: ");
            string izraz = Console.ReadLine();
            Console.WriteLine(izraz);

            if (izraz.Length % 2 == 0)
            {
                //parni broj znakova
                Console.WriteLine("Parno");
                bool palindrom = true;
                for (int i = 0; i < izraz.Length / 2; i++)
                {
                    if (izraz[i] != izraz[izraz.Length - 1 - i])
                    {
                        palindrom = false;
                        break;  
                    }

                }
                Console.WriteLine(palindrom ? "DA":"NE");


            }
            else
            {
                //neparni broj znakova
                Console.WriteLine("Neparno");
            }


        }
        //abbba
        //kisik
        //anavolimilovana
        //amenetuniminutenema
    }
}
