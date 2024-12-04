using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E02VarijabliTipoviPodataka
    {
        public static void Izvedi()
        {
            // Console.WriteLine("Hello E02");   
            int i;
            Console.WriteLine("Upisi broj: ");
         

            i=int.Parse(Console.ReadLine());
            Console.WriteLine("Upisali ste {0},i evo ga jos jednom {1}",i,i);

            bool logickaVrijednost;
            Console.Write("Unesi True ili False:");
            logickaVrijednost= bool.Parse(Console.ReadLine());
            Console.WriteLine( "Unjeli ste {0}",logickaVrijednost);

            Console.Write("Unesi broj (,za decimalni dio): ");

            Console.WriteLine(float.Parse(Console.ReadLine()));
            float broj = 3.14F;


            Console.Write("unesi ime; ");
            string ime = Console.ReadLine();
            Console.WriteLine("Unio sam \n{0}\n{1}\n{2}\n{3}", i, logickaVrijednost, broj, ime);

        }
            

        
    }
}
