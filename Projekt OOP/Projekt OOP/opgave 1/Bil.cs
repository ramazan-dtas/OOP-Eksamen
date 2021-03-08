using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_OOP.opgave_1
{
    struct Bil
    {
        private string Mærke { get; set; }
        public int? Alder { get; set; }

        public Bil(string mærke, DateTime Årstal)
        {
            Mærke = mærke;
            var alder = new Alder(Årstal);
            Alder = alder.værdi;            
        }
        
        public string GetMærke()
        {
            return Mærke;
        }
    }
}
