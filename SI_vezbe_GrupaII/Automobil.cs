using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_vezbe_GrupaII
{
    class Automobil
    {
        private string marka;
        private int godinaProizvodnje;
        private double cena;
        private string registarskiBroj;

        public string Marka { get => marka; set => marka = value; }
        public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }
        public double Cena { get => cena; set => cena = value; }
        public string RegistarskiBroj { get => registarskiBroj; set => registarskiBroj = value; }

        public void Unos()
        {
            Console.WriteLine("Unesite podatke o automobilu:");
            Console.WriteLine("Unesite marku: ");
            this.Marka = Console.ReadLine();
            Console.WriteLine("Unesite godinu proizvodnje: ");
            this.GodinaProizvodnje = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite cenu: ");
            this.Cena = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite registarki broj: ");
            this.RegistarskiBroj = Console.ReadLine();
        }

        public void Ispis()
        {
            Console.WriteLine("Podaci o vozilu:\nMarka: "+this.Marka+"\nGodina " +
                "proizvodnje: "+this.GodinaProizvodnje+"\nCena: "+this.Cena+"\nRegistarski" +
                " broj: "+this.RegistarskiBroj);
        }

        
    }
}
