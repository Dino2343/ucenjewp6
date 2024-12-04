using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E02Z1
    {
        public static void Izvedi()
        {
            Console.Write("Unesi ime:");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesi broj godina (cijeli broj))");
            int godine =int .Parse(Console.ReadLine());

            Console.WriteLine("osoba ima {0} ima {1} god.",ime,godine);
           


        }


    }
}
