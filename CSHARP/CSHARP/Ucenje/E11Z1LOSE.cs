﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E11Z1LOSE

    {
        //program unosi dva cijela broja i ispiesuje njihov zbroj   
        //program moora biti bulletproof
        public static void Izvedi()
        {
            int broj1, broj2;

            while (true)
            {
                Console.WriteLine("Unesi prvi broj: ");
                try
                {
                    broj1 = int.Parse(Console.ReadLine());
                    break;

                }
                catch
                {
                    Console.WriteLine("Nisi unio broj!");

                }

            }
            while (true)
            {
                Console.WriteLine("Unesi Drugi broj: ");
                try
                {
                    broj2 = int.Parse(Console.ReadLine());
                    break;

                }
                catch
                {
                    Console.WriteLine("Nisi unio broj!");

                }
            }
            Console.WriteLine("{0}+{1}={2} ",broj1,broj2,broj1 + broj2);

        }
    }
}