using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public double Waga { get; set; } // w kg
        public double Wzrost { get; set; } // w metrach

        public Osoba(string imie, string nazwisko, double waga, double wzrost)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Waga = waga;
            Wzrost = wzrost;
        }

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine($"Imię: {Imie} {Nazwisko}");
            Console.WriteLine($"Waga: {Waga} kg, Wzrost: {Wzrost} m");
        }
    }
}
