using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autokeletkora
{
    public class Főpogram
    {
        static void Main(string[] args)
        {
            //autok.cs adatok string marka, string tipus, int gyartasi_ev, double megtett_kilometer, int utolso_szerviz
            var skoda = new Autok("Skoda","fabia",2004,250000,10000);
            var volvo = new Autok("Volvo", "v70",2005,30000,20000);
            skoda.EletkorKiszamit();
            volvo.EletkorKiszamit();
            Console.WriteLine("márka     |típus     |gyártási év   |megtett kilométer     |utolsó szervíz     ");
            skoda.Adatkiir();
            volvo.Adatkiir();
            skoda.SzervizSzukseges();
            volvo.SzervizSzukseges();
            skoda.Osszehasonlit(volvo);
            
            Console.ReadKey();
        }
    }
}
