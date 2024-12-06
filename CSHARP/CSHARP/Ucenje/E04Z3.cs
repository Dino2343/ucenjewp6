using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z3
    {
        public static void Izvedi()
        {
            Console.Write("Unesite 2 broja: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("Manji broj je: " + a);
            }
            else if (b < a)
            {
                Console.WriteLine("Manji broj je: " + b);
            }
            else
            {
                Console.WriteLine("Brojevi su isti.");
            }



            Console.Write("Unesite 3 broja: ");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            if (c <= d && c <= e)
            {
                Console.WriteLine("Najmanji broj je: " + c);
            }
            else if (d <= c && d <= e)
            {
                Console.WriteLine("Najmanji broj je: " + d);
            }
            else
            {
                Console.WriteLine("Najmanji broj je: " + e;
            }
        }

    }
}
