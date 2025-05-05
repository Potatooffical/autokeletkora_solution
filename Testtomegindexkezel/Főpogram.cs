using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testtomegindexkezel
{
    public class Főpogram
    {
        static void Main(string[] args)
        {
            var ferenc = new Ember("Gyurcsány Ferenc",2003,"Fiú",175,75);

            Console.WriteLine($"Ferenc adatai: {ferenc.Eletkor()},{ferenc.atalakit()},{ferenc.Testtomegindex()}");

            ferenc.Kiir();


            Console.ReadKey();
        }
    }
}
