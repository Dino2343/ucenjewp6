using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam

    // apstrapna klasa je ona klasa koja ne moze imati instancu
    // sluzi tome da zadrzava zajednicka svojstva i metode te da ju netko nasljedi 
{
    internal abstract class Entitet : Object // 
    {
        public int Sifra { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
