using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z1
    {
        public static void Izvedi()
        {
            Console.Write("Unesite broj godina: ");
            int godine = int.Parse(Console.ReadLine());
            if (godine < 0 | godine > 112)
            {
                Console.WriteLine("GREŠKA");
                return;
            }
            if (godine >= 18 )
            {
                Console.WriteLine("Punoljetan");

            }
            else
            {
                Console.WriteLine("Maloljetan");
            }
          


        }
    }
}
