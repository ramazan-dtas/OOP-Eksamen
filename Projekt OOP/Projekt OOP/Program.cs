using Projekt_OOP.opgave_1;
using Projekt_OOP.opgave_2;
using System;
using System.ComponentModel;

namespace Projekt_OOP
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Bil p1 = new Bil(1990, "bmw");
            Console.WriteLine(p1);
            
            Console.WriteLine("Hvis du vil lave en ny bil skal du trykke enter. Ellers gå ud af programmet");
            Console.ReadKey();
            Console.WriteLine("bilens årgang: ");
            int årgangen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bilens mærke: ");
            string mærke = Console.ReadLine();
            Bil p2 = new Bil(årgangen, mærke);
            Console.WriteLine(p2);*/

            Bil p1 = new Bil("audi",new DateTime(2010,12,24));
            Console.WriteLine(p1);

            var Nybil = p1;
            p1.Alder = 30;
            Console.WriteLine($"Bilens nye alder {Nybil} år");
            /*
            audi a1 = new audi(543, "a7", "18'");
            Console.WriteLine(a1);*/

            
        }
    }
}
