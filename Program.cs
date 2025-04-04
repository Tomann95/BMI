
using BMI;

class Program
{
    static void Main()
    {
        Console.Write("Podaj imię: ");
        string imie = Console.ReadLine();

        Console.Write("Podaj nazwisko: ");
        string nazwisko = Console.ReadLine();

        Console.Write("Podaj wagę w kg: ");
        double waga = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wzrost w metrach: ");
        double wzrost = Convert.ToDouble(Console.ReadLine());

        try
        {
            Pacjent pacjent = new Pacjent(imie, nazwisko, waga, wzrost);
            Console.WriteLine("\n📌 Wyniki:");
            pacjent.WyswietlInformacje();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Błąd: {ex.Message}");
        }
    }
}