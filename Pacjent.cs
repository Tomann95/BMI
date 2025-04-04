using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Pacjent : Osoba
    {
        public Pacjent(string imie, string nazwisko, double waga, double wzrost)
            : base(imie, nazwisko, waga, wzrost) { }

        public double ObliczBMI()
        {
            if (Wzrost <= 0)
            {
                throw new ArgumentException("Wzrost musi być większy od zera.");
            }
            return Waga / (Wzrost * Wzrost);
        }

        public string InterpretujBMI()
        {
            double bmi = ObliczBMI();

            if (bmi < 18.5) return "Niedowaga";
            if (bmi >= 18.5 && bmi < 24.9) return "Prawidłowa waga";
            if (bmi >= 25 && bmi < 29.9) return "Nadwaga";
            return "Otyłość";
        }

        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.WriteLine($"BMI: {ObliczBMI():F2} ({InterpretujBMI()})");
        }
    }
}
