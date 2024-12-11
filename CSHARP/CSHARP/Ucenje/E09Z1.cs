using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E09Z1
    {
        public static void Izvedi()
        {
            Console.Write("Unesite cijeli broj: ");
            int n = int.Parse(Console.ReadLine());
            int zbroj = 0;
            int broj = 2;
            while (broj <= n)
            {
                zbroj += broj;  
                broj += 2;      
            }
              Console.WriteLine("Zbroj svih parnih brojeva od 1 do " + n + " je: " + zbroj);
        }


    }
}
