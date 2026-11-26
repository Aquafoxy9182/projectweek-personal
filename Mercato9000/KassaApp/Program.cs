using System.Globalization;
using WinkelDomein;
using BetaalSysteemMock;
using System.Runtime.CompilerServices;

namespace KassaApp;

public class Ticked
{
    public string Barcode;
    public string Naam;
    public string Prijs;
    public string Btw;
    public string Aantal;

    public List<List<string>> Producten = new List<List<string>>();

    public void getInfo(string barcode)
    {
        string[] info = File.ReadAllLines("C:\\Users\\aqua\\Documents\\Mercato9000\\data\\producten.csv");

        List<string> Product = new List<string>();
        foreach (string line in info)
        {
            string[] values = line.Split(';');
            if (values[0] == barcode)
            {
                Product.Add(values[1]);
                Product.Add(values[2]);
                Product.Add(values[3]);
            }
        }
        Producten.Add(Product);
    }
}

public class Program
{
    public static void tickedScreen(string totaal, string ticketId, string prijs, string naam, int aantal, string txt)
    {
        int lineLenght = 40;
        txt += $"Naam: {naam} Prijs: {prijs} Aantal: {aantal}\n `";
        //base info screen
        for (int line = 0; line < lineLenght; line++)
        {
            Console.Write("-");
        }
        Console.WriteLine("");
        Console.WriteLine($"MERCATO 9000");
        Console.WriteLine($"Orderingsnummer: {ticketId}");
        DateTime now = DateTime.Now;
        Console.WriteLine($"Datum en tijd: {now}");
        for (int line = 0; line < lineLenght; line++)
        {
            Console.Write("-");
        }
        Console.WriteLine("");
        Console.Write(txt);
    }
    public static void Main(string[] args)
    {
        string txt = "";
        decimal totaal = 0;

        string ticketId = Guid.NewGuid().ToString();

        Ticked ticked1 = new Ticked();

        while (true)
        {
            Console.WriteLine("Voer de barcode in (of typ exit):");

            string barcode = Console.ReadLine();

            if (barcode.ToLower() == "exit")
            {
                break;
            }

            ticked1.getInfo(barcode);

            if (ticked1.Producten.Count > 0)
            {
                List<string> productInfo = ticked1.Producten.Last();

                string naam = productInfo[0];
                string prijs = productInfo[1];
                string btw = productInfo[2];

                int aantal = 1;

                decimal productPrijs = decimal.Parse(
                    prijs,
                    CultureInfo.InvariantCulture
                );

                totaal += productPrijs * aantal;

                tickedScreen(
                    totaal.ToString("F2"),
                    ticketId,
                    prijs,
                    naam,
                    aantal,
                    txt
                );
            }
            else
            {
                Console.WriteLine("Product niet gevonden.");
            }
        }
    }
}
