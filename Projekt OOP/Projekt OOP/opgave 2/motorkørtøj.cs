using Projekt_OOP.opgave_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_OOP.opgave_2
{
    abstract class motorkørtøj//Det her er min abstract class
    {
        public string Model { get; set; }//normal properti
        public abstract DateTime SynDato { get; set; }//abstract properti

        public motorkørtøj(string model)//constructor
        {
            Model = model;
        }
    }
}
