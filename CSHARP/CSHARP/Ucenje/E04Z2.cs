﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z2
    {
        public static void Izvedi()
        {
            Console.Write("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 2 == 0)
            {
                Console.WriteLine("Paran");
            }
            else
            {
                Console.WriteLine("Neparan");
            }

            Console.WriteLine(broj % 2 == 0 ? "Paran" : "Neparan"  );

        }
    }
}