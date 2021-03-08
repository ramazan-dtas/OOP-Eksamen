using Projekt_OOP.opgave_1;
using Projekt_OOP.opgave_2;
using System;
using System.ComponentModel;

namespace Projekt_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil p1 = new Bil("audi",new DateTime(2010, 12, 24));
            Console.WriteLine($"{p1.Mærke} {p1.Alder}");

            var Nybil = p1;
            Nybil.Alder = 30;
            Console.WriteLine(Nybil.Alder);
            Console.WriteLine("-------------------------OPGAVE 2-----------------------");
            audi a1 = new audi("DF 10 254", new DateTime(2012, 3, 10), "Personbil");
            Console.WriteLine(a1);
        }
    }
}
