using Projekt_OOP.opgave_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_OOP.opgave_2
{//Child klasse
    class audi : Bil
    {
        private string DiffPlade { get; set; }
        private string NrPlade { get; set; }
        private string Tekst { get; set; }
        private DateTime RegistreretDato { get; set; }

        public audi(string nrPlade, DateTime registreretDato, string diffPlade) : base(nrPlade, registreretDato) 
        {
            DiffPlade = diffPlade;
            NrPlade = nrPlade;
            RegistreretDato = registreretDato;
        }

        public override string ToString()
        {
            return $"Dato for registreret nummer plade: {RegistreretDato.Date}" +
                $"\nplade nummer: {NrPlade}\nhvilke slags: {DiffPlade}";
        }

        public string ToStringTekst(string tekst)
        {
            Tekst = tekst;
            return Tekst;
        }
    }
}
