﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E09Z2
    {
        public static void Izvedi()
        {
            int suma = 0,broj;
            while (true)
            {
                Console.WriteLine("unesi broj: ");
                broj = int.Parse(Console.ReadLine());
                if (broj == -1)
                {
                    break;
                }
                suma= suma + broj;
                
                
            }
            Console.WriteLine(suma);
        }
        
    }
}
