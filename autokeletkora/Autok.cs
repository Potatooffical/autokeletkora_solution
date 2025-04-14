using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace autokeletkora
{
    public class Autok
    {
        //konstruktor kétre hozva
        public Autok(string marka, string tipus, int gyartasi_ev, double megtett_kilometer, int utolso_szerviz)
        {
            this.marka = marka;
            this.tipus = tipus;
            this.gyartasi_ev = gyartasi_ev;
            this.megtett_kilometer = megtett_kilometer;
            this.utolso_szerviz = utolso_szerviz;
        }
        //márka, típus, gyártási év, megtett kilométer, utolsó szervíz
        //pl toyota,yaris,1999,230000km,2022
        //osztály létrehozva
        public string marka { get; set; }
        public string tipus { get; set; }
        public int gyartasi_ev { get; set; }
        public double megtett_kilometer { get; set; }
        public int utolso_szerviz { get; set; }
        //életkor kiszámítása (aktuális év alapján);
        public void EletkorKiszamit()
        {
            int eletkor = DateTime.Now.Year - gyartasi_ev;
            Console.WriteLine($"{marka} életkora:{eletkor} év");
        }
        //szerviz szükségességének eldöntése(pl.ha 20000 km-t megtett az utolsó szerviz óta)
        public void SzervizSzukseges()
        {

            if (megtett_kilometer - utolso_szerviz >= 200000)
            {
                Console.WriteLine("Szerviz szükséges!");
            }
            else
            {
                Console.WriteLine("Nem szükséges szerviz! azaz jó az autód most...");
            }
        }
        public void Adatkiir()
        {
            Console.WriteLine($"{marka ,-10 }|{tipus ,-10}|{gyartasi_ev ,-14}|{megtett_kilometer,-22}|{utolso_szerviz,-15}");
        }
        //összehasonlító metódus, amely megmondja, melyik autó fiatalabb.
        public void Osszehasonlit(Autok auto)
        {
            if (auto.gyartasi_ev > gyartasi_ev)
            {
                Console.WriteLine($"Ez a {auto.marka} Fiatlabb");
            }
            else
            {
                Console.WriteLine($"Ez a {marka} Idősebb");
            }
        }
    }
}