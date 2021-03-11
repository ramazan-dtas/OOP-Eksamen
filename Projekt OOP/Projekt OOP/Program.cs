using Projekt_OOP.opgave_1;
using Projekt_OOP.opgave_2;
using Projekt_OOP.opgave_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Projekt_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------OPGAVE 1-------------------------");
            Bil p1 = new Bil("audi",new DateTime(2010, 12, 24));
            Console.WriteLine($"{p1.GetMærke()} {p1.Alder}");

            var Nybil = p1;
            Nybil.Alder = 30;
            Console.WriteLine(Nybil.Alder);

            Console.WriteLine("-------------------------OPGAVE 2-------------------------");
            audi a1 = new audi("DF 10 254", new DateTime(2012, 3, 10), "Personbil");
            Console.WriteLine(a1);

            Console.WriteLine("-------------------------OPGAVE 3-------------------------");
            string[] diffcolor = Enum.GetNames(typeof(MyEnum));//Den laver min Enum om til Array af string
            try
            {
                var liste = new List<AudiModel>()//Min liste
                {
                    new AudiModel(){Model = "a7", Årgang = new DateTime(2012, 5, 20), MotorStørrelse = 1.2, farve = diffcolor[0].ToString()/*Farve = sort*/},
                    new AudiModel(){Model = "a5", Årgang = new DateTime(2010, 3, 12), MotorStørrelse = 2.0, farve = diffcolor[1].ToString()/*Farve= "blå"*/},
                    new AudiModel(){Model = "a4", Årgang = new DateTime(2005, 12, 31), MotorStørrelse = 1.4, farve = diffcolor[2].ToString()/*Farve= "gul"*/},
                    new AudiModel(){Model = "quattro", Årgang = new DateTime(2017, 9, 15), MotorStørrelse = 3.0, farve = diffcolor[0].ToString()/*Farve= "sort"*/},
                    new AudiModel(){Model = "rs7", Årgang = new DateTime(2021, 2, 12), MotorStørrelse = 3.0, farve = diffcolor[3].ToString()/*Farve = "rød"*/}
                };
                var listAfBiler = liste.Where(x => x.farve.Contains("sort")).ToList();//tæller hvor mange sorte biler der er i min liste
                if(listAfBiler.Count() == 0)
                {
                    throw new Exception("Listen er Tom!");
                }

                foreach (var item in liste)//foreach giver mig lov til at outpute min liste AudiModel
                {
                    /*Her bliver min liste printet*/Console.WriteLine($"Model: {item.Model} Årgang: {item.Årgang} Motor størrelse: {item.MotorStørrelse} Farve: {item.farve}");
                }
                Console.WriteLine($"Antal sorte biler: {listAfBiler.Count()}");//printer hvor mange sorte biler der er i min liste
            }
            catch (Exception e)//hvis der er fejl oppe ved try så kommer der n fejl besked
            {

                Console.WriteLine(e.Message);
            }
            finally{//Når der ikke er mere at udskrive lige meget om der er fejl eller ej så kommer det her ud
                Console.WriteLine("Listen er tom!");
            }
        }
    }
}
