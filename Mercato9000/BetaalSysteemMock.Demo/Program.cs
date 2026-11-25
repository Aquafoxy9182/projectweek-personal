using WinkelDomein;
using BetaalSysteemMock;

// ════════════════════════════════════════════════════════════════════
//  Demo: hoe gebruik je de MockBetaalTerminal?
// ════════════════════════════════════════════════════════════════════
//
//  De MockBetaalTerminal bootst een betaalterminal na, zodat je
//  kaartbetalingen kan testen zonder echte hardware.
//
//  Wat je moet weten:
//  - Je vraagt een betaling met VerzoekBetaling(bedrag, boodschap).
//  - Lukt de betaling, dan krijg je een BetaalDetails-object terug
//    (kaarttype, gemaskeerd kaartnummer, bedrag, referentie, ...).
//  - Lukt de betaling niet, dan krijg je null terug. De mock simuleert
//    zo willekeurig een mislukte betaling: gemiddeld 1 op de 10.
//    Je kassa moet daar dus mee om kunnen (het ticket blijft open).
//  - Een betaling duurt standaard 3 tot 30 seconden, net als aan een
//    echte kassa. Om sneller te testen geef je zelf een kortere
//    wachttijd mee: new MockBetaalTerminal(50, 200) wacht 50-200 ms.
//
// ════════════════════════════════════════════════════════════════════

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("╔══════════════════════════════════════════╗");
Console.WriteLine("║  Demo: MockBetaalTerminal                ║");
Console.WriteLine("╚══════════════════════════════════════════╝");
Console.WriteLine();

// ─── Stap 1: de essentie ────────────────────────────────────────
//
//  DIT IS WAT JE OVERNEEMT IN JE KASSA-APP:
//
//      IBetaalTerminal terminal = new MockBetaalTerminal();   // één keer, bij het opstarten
//
//      BetaalDetails? betaling = terminal.VerzoekBetaling(bedrag, boodschap);
//      if (betaling == null)
//      {
//          // De betaling is mislukt: het ticket blijft open.
//      }
//      else
//      {
//          // De betaling is gelukt: betaling.Bedrag, betaling.KaartType, ...
//      }
//
//  Alles hierna (kleuren, de lus in stap 2) is enkel om de demo te tonen.

Console.WriteLine("── Stap 1: één betaling (3 tot 30 seconden wachten) ──");
Console.WriteLine();

IBetaalTerminal terminal = new MockBetaalTerminal();

Console.WriteLine("Betaling van € 25,50 wordt aangevraagd...");
Console.WriteLine();

BetaalDetails? betaling = terminal.VerzoekBetaling(25.50m, "Demo Winkel - Test");

if (betaling == null)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Betaling mislukt (VerzoekBetaling gaf null terug).");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Betaling geslaagd!");
    Console.ResetColor();
    Console.WriteLine($"  Kaart:      {betaling.KaartType} {betaling.KaartVariant}");
    Console.WriteLine($"  Nummer:     {betaling.GemaskerdKaartnummer}");
    Console.WriteLine($"  Methode:    {betaling.Methode}");
    Console.WriteLine($"  Bedrag:     € {betaling.Bedrag:F2}");
    Console.WriteLine($"  Referentie: {betaling.TransactieReferentie}");
    Console.WriteLine($"  Tijdstip:   {betaling.Tijdstip:yyyy-MM-dd HH:mm:ss}");
}

// ─── Stap 2: veel snelle betalingen, om de mislukkingen te zien ─

Console.WriteLine();
Console.WriteLine("── Stap 2: 20 snelle pogingen (50-200 ms) ──");
Console.WriteLine("   (gemiddeld 1 op de 10 mislukt)");
Console.WriteLine();

IBetaalTerminal snelleTerminal = new MockBetaalTerminal(minWachtMs: 50, maxWachtMs: 200);

int geslaagd = 0;
int mislukt = 0;

for (int i = 1; i <= 20; i++)
{
    Console.Write($"  Poging {i,2}: ");
    BetaalDetails? r = snelleTerminal.VerzoekBetaling(10.00m, "Snelle test");
    if (r == null)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("MISLUKT (null)");
        Console.ResetColor();
        mislukt++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"OK — {r.KaartType} {r.KaartVariant} ({r.Methode})");
        Console.ResetColor();
        geslaagd++;
    }
}

Console.WriteLine();
Console.WriteLine($"  Resultaat: {geslaagd} geslaagd, {mislukt} mislukt.");

Console.WriteLine();
Console.WriteLine("Druk op een toets om af te sluiten...");
Console.ReadKey(true);

// ════════════════════════════════════════════════════════════════════
//  Voor wie meer wil weten: waarom een interface?
// ════════════════════════════════════════════════════════════════════
//
//  Dit hoef je niet te kennen om de terminal te gebruiken. Het is
//  meegenomen, voor wie het interesseert.
//
//  De interface IBetaalTerminal staat in WinkelDomein. De mock die ze
//  implementeert, MockBetaalTerminal, staat in een aparte library,
//  BetaalSysteemMock.
//
//  De code die betalingen vraagt (bv. je kassa-app) kent enkel de
//  interface: ze roept VerzoekBetaling op, maar weet niet welke
//  terminal erachter zit. Enkel op één plaats, bij het opstarten,
//  wordt gekozen welke implementatie gebruikt wordt:
//
//      IBetaalTerminal terminal = new MockBetaalTerminal();
//
//  Komt er later een echte terminal, dan verandert enkel die ene regel,
//  bv.:
//
//      IBetaalTerminal terminal = new WorldlineTerminal(poort: "COM3");
//
//  De rest van de code blijft ongewijzigd. Dit heet "dependency
//  inversion": wie de terminal gebruikt, legt in een interface vast
//  wát nodig is; de implementatie bepaalt hóe het gebeurt.
//
// ════════════════════════════════════════════════════════════════════
