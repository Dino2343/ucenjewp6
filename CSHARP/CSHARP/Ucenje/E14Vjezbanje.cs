using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Vjezbanje
    {
        public static void Izvedi()
        {
            Console.WriteLine("Dobrodosli u vjezbanje petkom");
            Izbronik();
            Console.WriteLine("Hvala na koristenju,bok");
        }
        private static void Izbronik()
        {
            string[] programi =
            {
                "Parnost broja",
                "Tablica mnozenja",
                "Jedinicna vrijednost",
                "Broj znakova u nazivu mjesta"
            };


            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
          for(int i = 0; i < programi.Length; i++)
            {
                Console.WriteLine("{0}.{1}",i + 1, programi[i]);
            }
            Console.WriteLine("0.Izlaz iz programa");
            OdabirOpcijeIzbornika(programi.Length);
        }
        private static void OdabirOpcijeIzbornika(int programa)
        {
            switch (E12Metode.UcitajCijeliBroj("Odaberi stavku izbornika:", 0, programa))
            {
                case 0:
                    break;
                case 1:
                    ParnostBroja();
                    Izbronik();
                    break;
                case 2:
                    TablicaMnozenja();
                    Izbronik();
                    break;
                case 3:
                    JedinicnaVrijednost();
                    Izbronik();
                    break;
                    case 4:
                    BrojZnakovaNazivaMjesta();
                    Izbronik(); 
                    break;

            }
        }

        private static void BrojZnakovaNazivaMjesta()
        {
            NaslovPrograma("Za uneseni naziv mjesta ispisuje koliko ima znakova");

        }

        private static void JedinicnaVrijednost()
        {
            NaslovPrograma("Jedinicna vrijednost");
            int broj = E12Metode.UcitajCijeliBroj("Unesi broj izmedu 20 i 50: ", 20, 50);
            Console.WriteLine(broj%10);
        }

        private static void TablicaMnozenja()
        {

            NaslovPrograma("Program koji dane brojeve redaka i stupaca generira tablicu mnozenja");
            int redaka = E12Metode.UcitajCijeliBroj("Unesi broj redaka: ", 2, 10);
            int stupaca = E12Metode.UcitajCijeliBroj("Unesi broj stupaca: ", 2, 10);
            for (int i = 1; i <= redaka; i++)
            {
                for (int j = 1; j <= stupaca; j++)
                {
                    Console.Write("{0,4}", i * j);

                }
                Console.WriteLine();
            }


        }

        private static void ParnostBroja()
        {

            NaslovPrograma("Program koji provejrava jeli uneseni broj paran ili neparan");

            int broj = E12Metode.UcitajCijeliBroj("Unesi cijeli broj: ");
            if (broj % 2 == 0)
            {
                Console.WriteLine("Uneseni brij {0} je paran", broj);
            }
            else
            {
                Console.WriteLine("Uneseni broj {0} je neparan", broj);
            }
        }
        public static void NaslovPrograma(string naslov)
        {
            //Console.WriteLine("*************");
            NaglasiNaslov(naslov.Length);
            Console.WriteLine(naslov);
            NaglasiNaslov(naslov.Length);
        }
        private static void NaglasiNaslov(int komada)
        {
            for (int i = 0; i < komada; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

        }


    }

}

