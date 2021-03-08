using Projekt_OOP.opgave_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_OOP.opgave_2
{//Child klasse
    class audi : Bil
    {
        private string diffPlade { get; set; }
        private string nrPlade { get; set; }
        private DateTime registreretDato { get; set; }

        public audi(string NrPlade, DateTime RegistreretDato, string DiffPlade) : base(NrPlade, RegistreretDato) 
        {
            diffPlade = DiffPlade;
            nrPlade = NrPlade;
            registreretDato = RegistreretDato;
        }

        public override string ToString()
        {
            return $"Dato for registreret nummer plade: {registreretDato.Date}" +
                $"\nplade nummer: {nrPlade}\nhvilke slags: {diffPlade}";
        }
    }
}
