using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace Projekt_OOP.opgave_1
{
    struct Alder
    {
        public int? værdi { get; set; }
        
        public Alder(DateTime Årstal)
        {
            værdi = null;
            værdi = Udregning(Årstal);
        }

        private int Udregning(DateTime Årstal)
        {
            return DateTime.Now.Year - Årstal.Year;
        }
    }
}
