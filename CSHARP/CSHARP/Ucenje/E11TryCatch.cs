using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E11TryCatch
    {
        public static void Izvedi()
        {
            // Console.WriteLine("e");
            int broj;
            while (true)
            {
                try
                {
                    Console.WriteLine("Unesi cijeli broj: ");
                    broj = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Nisi unio cijeli broj!");
                }
            }
            // Console.WriteLine("bravo unjeli ste {0}", broj);

            int godine;
            while (true)
            {
                Console.WriteLine("Unesi svoj broj godina: ");
                try
                {
                    godine = int.Parse(Console.ReadLine());
                    if (godine < 1 || godine > 104)
                    {
                        Console.WriteLine("Uneseni broj godina nije dobar!");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Nisi dobro unio broj godina");


                }

            }
            Console.WriteLine("Broj godina osobe je {0}", godine);

            //unesi grad 
            int ascii;
            string grad;
            bool ok;
            for (; ; )
            {
                Console.WriteLine("Unesi ime grada: ");
                grad = Console.ReadLine().Trim();
                if (grad.Length == 0)
                {
                    Console.WriteLine("Nisi unio ime grada");
                    continue;
                }
                try
                {
                    int.Parse(grad);
                    Console.WriteLine("Ime grada ne moze biti broj!");
                    continue;
                }
                catch
                {
                    ok = true;
                    foreach (char c in grad.ToUpper())
                    {
                        ascii = (int)c;
                        if (ascii < 65 || ascii > 90)
                        {
                            ok=false;
                            break;
                        }
                    }
                    if(!ok)
                    {
                        Console.WriteLine("Problem s jednim znakom u nazivu grada.");
                        continue;
                    }

                }
                break;
            }
            Console.WriteLine("Unjeli ste: >{0}<", grad);
        }
    }
}
