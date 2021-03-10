using Projekt_OOP.opgave_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_OOP.opgave_2
{
    abstract class motorkørtøj
    {
        public string Model { get; set; }
        public abstract DateTime SynDato { get; set; }

        public motorkørtøj(string model)
        {
            Model = model;
            
        }
    }
}
