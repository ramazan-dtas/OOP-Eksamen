using Projekt_OOP.opgave_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_OOP.opgave_1
{
    class Bil: motorkørtøj
    {
        private string Mærke { get; set; }
        public int? Alder { get; set; }
        public override DateTime SynDato { get; set; }

        public Bil(string mærke, DateTime Årstal) : base(mærke)
        {
            Mærke = mærke;
            var alder = new Alder(Årstal);
            Alder = alder.værdi;
            SynDato = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
        
        public string GetMærke()
        {
            return Mærke;
        }
    }
}