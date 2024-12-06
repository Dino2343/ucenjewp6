

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

            Console.WriteLine("osoba {0} ima {1} god.",ime,godine);
           


        }


    }
}
