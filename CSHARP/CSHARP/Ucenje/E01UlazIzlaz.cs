﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E01UlazIzlaz
    {
        public static void Izvedi()
        {
            //izlaz
            Console.Write("Unesi svoje ime: ");

            //ulaz
            string ime = Console.ReadLine();
            Console.WriteLine("Unjeli ste", ime);

            // formatirani 
            Console.WriteLine("unjeli ste{0}. Bravo", ime);
        }


    }
}
