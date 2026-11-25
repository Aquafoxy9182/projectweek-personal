using System.Globalization;
using WinkelDomein;
using BetaalSysteemMock;
using System.Runtime.CompilerServices;

namespace KassaApp;

public class Ticked
{
    public string Barcode;
    public string Naam;
    public decimal Prijs;
    public decimal Btw;
    public int Aantal;

    public Ticked(string barcode)
    {
        this.Barcode = barcode;
    }

    public void ShowInfo()
    {
        string[] info = File.ReadAllLines("C:\\Users\\aqua\\Documents\\Mercato9000\\data\\producten.csv");

        foreach (string line in info)
        {
            string[] values = line.Split(';');
            if (values[0] == Barcode)
            {
                Naam = values[1];
                Prijs = decimal.Parse(values[2], CultureInfo.InvariantCulture);
                Btw = decimal.Parse(values[3], CultureInfo.InvariantCulture);
                Console.WriteLine($"Naam: {Naam}, Prijs: {Prijs}, Btw: {Btw}");
            }
        }
    }
}

public class Program
{
    public void tickedScreen(decimal totaal, string ticketId, decimal prijs, string naam)
    {
        //base info screen
        for (int line = 0; line < 5; line++)
        {
            Console.WriteLine("-");
        }
        Console.WriteLine($"MERCATO 9000");
        Console.WriteLine($"Orderingsnummer: {ticketId}");
        DateTime now = DateTime.Now;
        Console.WriteLine($"Datum en tijd: {now}");
    }
    public static void Main(string[] args)
    {
        Ticked ticked1 = new Ticked("2974649911097");
        ticked1.ShowInfo();
    }
}