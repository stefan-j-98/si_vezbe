using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_vezbe_GrupaII
{
    class Program
    {
        /*
        static void Compare(Automobil a1, Automobil a2)
        {
            if (a1.Cena > a2.Cena)
            {
                a1.Ispis();
            }  
            else if (a2.Cena > a1.Cena)
            {
                a2.Ispis();
            }
        }
        */
        static void Main(string[] args)
        {
            Country c = new Country();
            c.InsertCountry();
            c.PrintCountry();
            Console.ReadKey();
        }
    }
}
