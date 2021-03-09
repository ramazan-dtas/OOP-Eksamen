using Projekt_OOP.opgave_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_OOP.opgave_2
{//base class
    abstract class motorkørtøj 
    {
        public string model { get; set; }

        public motorkørtøj(string Model, DateTime SynDato)
        {
            model = Model;
        }
    }
}
