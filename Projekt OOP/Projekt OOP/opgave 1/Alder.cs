using Projekt_OOP.opgave_2;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace Projekt_OOP.opgave_1
{
    struct Alder//struct class
    {
        public int? værdi { get; set; }//Den her properti normal værdi er null
        
        public Alder(DateTime Årstal)
        {
            værdi = null;
            værdi = Udregning(Årstal);
        }

        private int Udregning(DateTime Årstal)//her bliver der udregnet alderen af en bil
        {
            return DateTime.Now.Year - Årstal.Year;
        }
    }
}
