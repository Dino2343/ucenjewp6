using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.zavrsnirad
{
    public class RekreativniRibolov
    {
        public int Sifra { get; set; }
        public string VrstaRibe { get; set; } = "";
        public string Oprema { get; set; } = "";
        public decimal MinimalnaMjera { get; set; } 
        public string Lokacija { get; set; } = "";
        public Ribe ribe = new Ribe();


    }
}
