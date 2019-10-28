using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_vezbe_GrupaII
{
    class Country
    {
        private string name;
        private string capitalCity;
        private double area;
        private int population;

        public string Name { get => name; set => name = value; }
        public string CapitalCity { get => capitalCity; set => capitalCity = value; }
        public double Area { get => area; set => area = value; }
        public int Population { get => population; set => population = value; }

        public void InsertCountry()
        {
            Console.WriteLine("\n Insert name: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("\n Insert capital city: ");
            this.CapitalCity = Console.ReadLine();
            Console.WriteLine("\n Insert area: ");
            this.Area = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Insert population: ");
            this.Population = int.Parse(Console.ReadLine());
        }

        public void PrintCountry()
        {
            Console.WriteLine("Name: {0} \n Capital city: {1} \n Area: {2} \n Population: {3} \n Density {4}",
                this.Name, this.CapitalCity, this.Area, this.Population, this.CalculateDensity());
        }

        public double CalculateDensity()
        {
            return this.Population / this.Area;
        }
    }
}
