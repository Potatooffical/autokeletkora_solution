﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testtomegindexkezel
{
    public class Ember
    {
        //név, születéis év, nem, magasság(cm)
        public string Nev { get; set; }
        public int Szuletesi_ev { get; set; }
        public string Nem { get; set; }
        public double Magassag { get; set; }
        public double Testsuly { get; set; }
        //konstrruktor létre hozzása
        public Ember(string nev, int szuletesi_ev, string nem, double magassag, double testsuly)
        {
            Nev = nev;
            Szuletesi_ev = szuletesi_ev;
            Nem = nem;
            Magassag = magassag;
            Testsuly = testsuly;
        }
        //számítsa ki az ember életkorát
        public int Eletkor()
        {
            return DateTime.Now.Year-Szuletesi_ev;
        }
        public double atalakit()
        {
            return 1.0*(double)Magassag / 100;
        }
        public double Testtomegindex()
        {

            return 1.3 * Testsuly / Math.Pow(atalakit(), 2.5);
        }
        public void Bmitabla()
        {
            double bmi = Testtomegindex();
            switch (bmi)
            {
                case double i  when i>0 && i<16:
                    Console.WriteLine("Súlyos soványság Észak-Koreai vagy akkor normális :)");
                    break;
                case double i when i >= 16 && i < 16.99:
                    Console.WriteLine("Mérséklet soványság");
                    break;
                case double i when i >= 17 && i < 18.49:
                    Console.WriteLine("Enyhe Soványság");
                    break;
                case double i when i >= 18.5 && i < 24.99:
                    Console.WriteLine("Normál Testsúly");
                    break;
                case double i when i >= 25 && i < 29.99:
                    Console.WriteLine("Túlsúlyos vagy Izom épités");
                    break;
                case double i when i >= 30 && i < 34.99:
                    Console.WriteLine("I. Fokú Elhízás sok a meki");
                    break;
                case double i when i >= 35 && i < 39.99:
                    Console.WriteLine("II. Fokú Elhízás kezd túl sokk lenni a meki");
                    break;
                case double i when i >= 40 && i< 100:
                    Console.WriteLine("III. Fokú Elhízás");
                    break;
                default:
                    Console.WriteLine("Hú ez magass");
                    break;
            }
        }
        //név, születéis év, nem, magasság(cm)

        public void Kiir()
        {
            Console.WriteLine($"{Nev},{Szuletesi_ev},{Nem},{Magassag},{Testsuly}");
            Console.WriteLine($"Életkor: {Eletkor()}");
            Console.WriteLine($"Magasság(m): {atalakit()}");
            Console.WriteLine($"TesttömegIndex: {Math.Round(Testtomegindex(),2)}");
            Console.Write($"Kiértékelés(BMI):");
            Bmitabla();
        }
        public string Bmitabla_WPF()
        {
            double bmi = Testtomegindex();
            string eredmeny=" ";
            switch (bmi)
            {
                case double i when i > 0 && i < 16:
                    eredmeny = "Súlyos soványság Észak-Koreai vagy akkor normális :)";
                    break;
                case double i when i >= 16 && i < 16.99:
                    eredmeny = "Mérséklet soványság";
                    break;
                case double i when i >= 17 && i < 18.49:
                    eredmeny = "Enyhe Soványság";
                    break;
                case double i when i >= 18.5 && i < 24.99:
                    eredmeny = "Normál Testsúly";
                    break;
                case double i when i >= 25 && i < 29.99:
                    eredmeny = "Túlsúlyos vagy Izom épités";
                    break;
                case double i when i >= 30 && i < 34.99:
                    eredmeny = "I. Fokú Elhízás sok a meki";
                    break;
                case double i when i >= 35 && i < 39.99:
                    eredmeny = "II. Fokú Elhízás kezd túl sokk lenni a meki";
                    break;
                case double i when i >= 40 && i < 100:
                    eredmeny = "III. Fokú Elhízás HAHÓ SOK A MEKI";
                    break;
                default:
                    eredmeny = "Hú ez magass";
                    break;
            }
            return eredmeny;
        }
    }
}
