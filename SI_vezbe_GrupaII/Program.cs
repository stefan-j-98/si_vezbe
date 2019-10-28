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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="countries"></param>
        static void SortDensity(Country[] countries)
        {
            for (var i = 0; i < countries.Length-1; i++)
            {
                for (var j = i + 1; j < countries.Length; j++)
                {
                    if (countries[i].CalculateDensity() >
                        countries[j].CalculateDensity())
                    {
                        var country = countries[i];
                        countries[i] = countries[j];
                        countries[j] = country;
                    }
                }
            }

            foreach (var country in countries)
            {
                Console.WriteLine($"{country.Name}!");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="countries"></param>
        static void MinDensity(Country[] countries)
        {
            var min = countries[0];
            foreach (var country in countries.Skip(1))
            {
                if (country.CalculateDensity() < min.CalculateDensity())
                {
                    min = country;
                }
            }
            
            Console.WriteLine($"Zemlja sa najmanjom gustinom je: {min.Name}!");
        }
        
        static void Main(string[] args)
        {
//            Country c = new Country();
//            c.InsertCountry();
//            c.PrintCountry();

            Console.WriteLine("Unesite n:");
            int n = int.Parse(Console.ReadLine());

            Country[] countries = new Country[n];
            
            for (int i = 0; i < n; i++)
            {
                Country country = new Country();
                country.InsertCountry();
                countries[i] = country;
            }
            SortDensity(countries);
            //MinDensity(countries);
            countries[countries.Length - 1].PrintCountry();
            Console.ReadKey();
        }

        
    }
}
