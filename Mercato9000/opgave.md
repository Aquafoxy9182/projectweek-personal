# Projectweek (week 10): Kassa ~ Mercato 9000

Maandag 23 november tot en met vrijdag 27 november.

Je wordt voor deze project geëvalueerd onder _Opdracht 6_ voor het opleidingsonderdeel _Programmeren Basis_. 

### Agenda

| Wanneer | Wat |
|---|---|
| maandag 9u15 | Publicatie van de opgave, zoek je groepsleden op en start samen met het doornemen van de opgave, opstellen van een eerste planning en verdeling van het werk. |
| maandag 9u45 – vrijdag 12u30 | Werken aan het project. Vrijdag 12u30 is de oplevering. |
| vrijdag om 12u30 | Oplevering op de branch `main` van jullie GitHub-repository (zie [Opleveren](#opleveren)) |
| vrijdag 13u00 – 17u45 | Iedereen woont de prensentaties bij van de studenten van het opleidingsonderdeel Werkplekproject 1 (deze studenten werken deze week aan een .NET MAUI app voor een exteren opdrachtgever, iets vergelijkbaars komt op jullie af volgend semester); en één groep onder jullie stellen hun Mercato 9000 resultaat voor. |

### Aanwezigheid

Aanwezigheid is **noodzakelijk**: je werkt in een groep, en je groep rekent op je. 

We verwachten je elke dag van 9u15 tot 15u30, op vrijdag tot 17u45. 
Een gewettigde afwezigheid kan, maar beperkt, en niet op cruciale momenten zoals maandag (de start) en vrijdag (de oplevering en de presentaties).  
Wie afwezig is stuur Frederiek zo spoedig mogelijk een bericht (frederiek.dewolf@hogent.be) om dat te melden.

Wat je voor dit project in groep bereikt, zal de basis vormen voor de eindopdracht van _Programmeren Basis_ (_Opdracht 7_).

### Lectoren

Enkele lectoren lopen rond en kunnen je adviseren.

De lectoren Programmeren Basis zijn de hele week aanwezig. De overige lectoren kan je af en toe zien passeren: hou je eventuele vragen voor hen klaar.

| Lectoren | Opleidingsonderdeel |
|---|---|
| F. De Wolf | Programmeren Basis. **Vertegenwoordiger van de klant Mercato 9000.** Vragen over wat de kassa moet doen, stel je aan hem. |
| Y. Inghelbrecht | Programmeren Basis |
| T. Van De Wiele en C. Ostijn | Software Ontwerp 1 |
| L. Mahieu en K. Verhoeyen | Web 1 |
| J. Li en W. Goedertier | Databanken |

## Samenwerken

Je werkt een hele week samen met dezelfde groep, in één codebase. Voor de meesten is dat nieuw, maar zo kan je hierin ervaring opbouwen.

**Iedereen is mede-eigenaar van het hele project.** Elk groepslid moet alles begrijpen, en elk deel kunnen voorstellen en verdedigen, ook de stukken die een ander heeft uitgewerkt. Het is ieders verantwoordelijkheid ervoor te zorgen dat elk teamlid mee is met het verhaal, en uiteindelijk begrijpt en kan duiden hoe alles functioneert.

**Eindig elke dag met het aan elkaar uitleggen (en centraal wegschrijven) van wat beslist, ontworpen en geïmplementeerd is.** Zo kan je de dag daarop de taken herverdelen, of werk van elkaar overnemen (misschien is je medestudent morgen wel ziek).

**Plan, en stuur bij.** Probeer samen te plannen, en bekijk de planning meermaals per dag opnieuw en stuur ze bij.

**Hoe jullie het werk verdelen, beslissen jullie zelf.** Iedereen een eigen taak, per twee of drie aan één scherm (*pair programming*), of samen aan het begin van de dag de lastige stukken en daarna verdelen: alles mag, zolang het voor jullie werkt. Doen jullie aan pair programming... dan helpt het dat wie technisch iets minder sterk is de vingers aan het toetsenbord houdt: de sterkere volgt mee, legt uit en stuurt zo nodig bij. Zorg bij taakverdelingen wel voor de nodige afwisseling, zo blijft iedereen automatisch ook op de hoogte van hoe alles functioneert.

AI: **We adviseren geen code te laten genereren.** Gegenereerde code is vaak *over-designed*: complexer dan nodig. En ook voor die code moet iedereen van het team zowel het waarom als het hoe kunnen verdedigen en verantwoorden. Je krijgt geen punten voor wat je oplevert, wel voor wat je kan verantwoorden en uitleggen (*code ownership*). Je verliest het vertrouwen (en positieve beoordeling) voor wat je niet kan duiden.

Een paar afspraken die veel problemen voorkomen:

- **Start elke dag met een korte stand-up** (enkele minuten): Elk komt aan bod: _wat heb ik gisteren gedaan_, _wat doe ik vandaag_, _waar zit ik vast_?
- **Zeg luidop wie wat doet.** Zo vermijd je dat je met twee aan hetzelfde werkt, en eventueel met verschillende oplossingen zit.
- **Hou één centrale versie bij.** Breng het werk van iedereen samen op één toestel (bv. door fragmenten of bestanden door te sturen in de MS Teams-chat), en push enkel vanop dat toestel naar jullie GitHub-repository; minstens op het einde van elke dag. Zo is er altijd één centrale back-up voor iedereen, en vermijd je dat wijzigingen van verschillende toestellen met elkaar botsen. Hoe je de repository aanmaakt en pusht, staat bij [Opleveren](#opleveren).
- **Zit je vast, zeg het.** Na een kwartier alleen zoeken: vraag het aan iemand van je groep. Na een half uur samen zoeken: vraag het aan een lector.

### Wat is belangrijk?

**Goed samenwerken en kwaliteit zijn belangrijker dan volledigheid.** Een kassa die niet alles kan, maar die goed werkt, is beter dan een kassa die alles half kan. Denk bij kwaliteit onder meer aan:

- **correctheid**: de kassa doet wat ze moet doen, en de bedragen kloppen;
- **robuustheid**: foute invoer laat de kassa niet crashen;
- **gebruiksvriendelijkheid**: de kassabediende en de klant zien duidelijk wat er gebeurt;
- **leesbaarheid en eenvoud**: de code is begrijpelijk, ook voor wie ze niet schreef, en niet complexer dan nodigara
- **onderhoudbaarheid**: een aanpassing of uitbreiding kan zonder alles om te gooien.

Volledigheid is ook een kwaliteitsfactor, maar in dit project niet de belangrijkste. Werk dus eerst de basis goed af, en breid daarna uit.

### Maak enkel gebruik van wat behandeld is

In je C# implementatie maak je enkel gebruik van taalelementen en coding guidelines zoals ook vermeldt in het leermateriaal van het opleidingsonderdeel Programmeren Basis.

Gebruik maken van LINQ, om maar iets te noemen, is bijvoorbeeld daarom niet toegestaan.

## Scenario

Je ontwikkelt het kassasysteem van de winkel **Mercato 9000** (Henleykaai 84, 9000 Gent). Het assortiment en de prijzen staan in de centrale databank van de back-office. Je krijgt een kopie van de creational sql die de databank (schema) construeert, en sql die de databank opvult met gegevens.  Deze databank kan je lokaal op je toestel opzetten.  Daaruit maak je een export van productinformatie van de producten "die vandaag ingescand kunnen worden".  De export plaats je in een CSV (comma separator values)-bestand. 
De kassa-app (je .NET Console App, targetframework 10.0) leest dat bestand in bij het opstarten, en kan zo met de informatie van de in te scannen producten werken.

De kassabediende werkt met de console-applicatie. Met een barcodescanner scant hij de barcodes in van de door de klant aangekochte producten.  Een toetsenbord laat de kassabediende toe om aantallen (of barcodes) manueel in te voeren, of menu-opties (die verschillende handelingen met de kassa toestaan, zie verderop) uit te kiezen.
De console applicatie toont op de de console het samengestelde kassaticket, met onder meer de producten, hun prijs inclusief btw, het totaalbedrag inclusief btw, ... .
De klant krijgt een eigen **klantenscherm** in de browser, met wat er gescand is en wat hij moet betalen.

## Wat je uit welk opleidingsonderdeel meebrengt

| Opleidingsonderdeel | Wat je ervan gebruikt in dit project |
|---|---|
| **Databanken** | De SQL-query die de scanbare producten uit de databank haalt: joins over meerdere tabellen, een prijshistoriek, werken met datums. |
| **Software Ontwerp 1** | Probleemoplossend denken en het databankschema doorgronden.  Eventueel een object-geörienteerde ontwerp voor je applicatie. |
| **Programmeren Basis** | De console-applicatie in C#: invoer verwerken, collecties, bestanden lezen en schrijven, foutafhandeling. |
| **Web 1** | Het klantenscherm: een verzorgde HTML-pagina met CSS-opmaak. |

## Wat je krijgt

| Wat | Waar |
|---|---|
| De databank `kassa` (MySQL 8), als script `kassa_databank.sql` | `databank/` |
| Een startsolution `Kassa.sln` met enkele projecten: `WinkelDomein`, `BetaalSysteemMock`, `BetaalSysteemMock.Demo` en `KassaApp` | deze map |
| `index.html`: toont het klantenscherm in de browser en werkt zichzelf bij | `klantscherm/` |
| `MockBetaalTerminal`: een nagebootste betaalterminal, met een demo-app die toont hoe je hem gebruikt | `BetaalSysteemMock/`, `BetaalSysteemMock.Demo/` |

Onderstaand is wat te doel valt in verschillende (genummerde) delen beschreven.  Bekijk samen eerst wat de bedoeling is van de verschillende delen, plan en verdeel dan het werk.

## Deel 1 — De export van de scanbare producten

Maak een **CSV-bestand** met van **elk scanbaar product**:

- de barcode;
- de omschrijving;
- de prijs exclusief btw (in euro zoals in de databank); en
- het btw-percentage.

**Wat is "scanbaar"?** Een product is **scanbaar** als er vandaag een prijs voor geldt: in de tabel `Prijs` staat voor dat product een rij waarvan de periode vandaag bevat. Elke rij is een prijs die geldt vanaf `GeldigVanaf` (die dag inbegrepen) tot `GeldigTot` (die dag niet meer: dan gaat de volgende prijs in). Is er voor een prijs nog geen einddatum gekend, dan is `GeldigTot` niet ingevuld. Een product zonder prijs, of met enkel prijzen die pas na vandaag ingaan, is niet scanbaar: dat signaleert immers dat het product niet meer, of nog niet, aanwezig is in de winkel.

Barcode en btw-tarief zijn in deze databank altijd ingevuld. Barcodes zijn altijd geldig. Alle prijzen in de databank zijn eurobedragen exclusief btw. In de omschrijvingen, barcodes, prijzen en percentages komt nooit een puntkomma (`;`) voor.

Minstens één iemand van de groep zet de databank op zijn eigen toestel klaar: voer `kassa_databank.sql` uit, bijvoorbeeld in MySQL Shell. Het script maakt de databank `kassa` (opnieuw) aan.

1. Verken de databank. Niet elke tabel is nodig, en niet elke kolom die er op het eerste zicht nuttig uitziet, is de juiste.
2. Schrijf en test je query tot het resultaat klopt.
3. Zorg dat het resultaat in een CSV-bestand terechtkomt. Hoe je dat doet, zoek je eventueel zelf uit.
4. Zet het CSV-bestand bij je solution, bv. als `data/producten.csv`. De kassa leest het in.
5. **Neem nota van je query** (en van hoe je de CSV maakte). Straks heb je die misschien opnieuw nodig, als we een nieuwe versie van de databank aanreiken.

Het formaat van het CSV-bestand (scheidingsteken, kopregel of niet, decimaalteken, ...) kiezen jullie zelf. Je kassa(-app) moet het wel correct kunnen inlezen.

### Controle

Een juist resultaat telt **18.691 producten**, en alle 18.691 producten hebben netjes een unieke barcode.

Een juist aantal rijen bewijst nog niet dat alles klopt. Ook met 18.691 rijen kan er nog dit mis zijn:

- de **prijs**: niet de prijs die vandaag geldt, maar bv. de hoogste prijs ooit, of een prijs die pas later ingaat;
- het **btw-percentage**: uit de verkeerde tabel gehaald;
- de **barcode**: een andere code uit de databank, die er alleen op lijkt.

Controleer jezelf: zoek enkele producten op in de databank en ga na of de prijs en het btw-percentage in je CSV kloppen. Scan je de barcodes van het testblad dat je krijgt (of voer je ze manueel in -als kassabediende- bij het gebruik van je nog te schrijven console app), dan moeten omschrijving, prijs en btw-percentage overeenkomen met wat erop staat.

> **Tip voor de groep.** Zolang de export niet klaar is, kan de rest van de groep al verder met een zelfgemaakt CSV-bestand van een tiental producten in het afgesproken formaat. Spreek dat formaat dus vroeg af, en wacht niet op elkaar.

## Deel 2 — De kassa (console app)

### Opstarten

- Bij het opstarten leest de kassa het CSV-bestand met de scanbare producten in. Daarna werkt ze (de hele dag allicht, of toch zolang de kassa opstaat) met de producten die in het geheugen zijn geladen.
- Na het inlezen toont de kassa een melding met het aantal ingeladen producten. Met een juiste export zijn dat er **18.691**.
- De kassa start direct in scanmodus. Na elke afgehandelde klant begint automatisch een nieuw kassaticket.

### Bediening

Het huidige kassaticket staat altijd op de console, samen met het menu van de mogelijke handelingen. Elke invoer wordt bevestigd met Enter.

| Invoer | Actie |
|---|---|
| een barcode | Scan 1 stuk van dat product: het wordt **toegevoegd** aan het ticket.  Het scannen zou met een barcodelezer kunnen gebeuren (als je zelf eens wil testen, kom hem vragen aan Frederiek die heeft hem van onze opdrachtgever meegekregen), of je kan als kassabediende manueel de barcode invoeren. (Lastig bij het testen... hoe gaan we hiermee om... ) |
| een getal | **Herhaal de toevoeging of verwijdering** dat aantal keer.  Voert de kassabediende bijvoorbeeld `5` in net nadat hij product X al voor een twee keer in had gescand, dan wordt het aantal van product X van twee verhoogd naar zeven. |
| menu-optie **verwijderen**, daarna een barcode | **Verwijder** 1 stuk van dat product |
| menu-optie **ongedaan maken** | Maak de laatste toevoeging of verwijdering ongedaan (ook als die een getal was) |
| menu-optie **afbreken** | Het ticket vervalt en er start een nieuw |
| menu-optie **parkeren** | Het ticket wordt opzij gezet en er start een nieuw |
| menu-optie **hervatten** | Kies een geparkeerd ticket; dat wordt opnieuw het huidige ticket |
| menu-optie **betalen met kaart** | Via de betaalterminal |
| menu-optie **cash betaald** | Bevestiging dat de klant contant betaald heeft |

Welke letters of toetsen je voor de menu-opties gebruikt, kies je zelf. Een voorstel: `D` verwijderen, `Z` ongedaan maken, `A` afbreken, `P` parkeren, `H` hervatten, `K` kaart, `C` cash.

**Scannen en verwijderen**
- Wordt hetzelfde product meermaals gescand, dan wordt de hoeveelheid bij de bestaande regel opgeteld. *Aanbeveling*: laat het product dan naar de onderkant van het ticket verhuizen, zodat het laatst gescande altijd onderaan staat.
- Een onbekende of niet-scanbare barcode geeft een melding, geen crash.

**Betalen**
- **Kaart**: de kassa spreekt de (meegegeven) betaalterminal aan. Lukt de betaling, dan start er een nieuw ticket. Lukt ze niet, dan blijft het ticket open en kan de kassabediende opnieuw proberen, cash laten betalen of afbreken.
- **Cash**: de kassabediende kiest deze menu-optie pas als de klant contant betaald heeft: de keuze is de bevestiging dat de betaling gebeurd is. De kassa toont die bevestiging en start een nieuw ticket.

**De betaalterminal**: `IBetaalTerminal` (in `WinkelDomein`) met `VerzoekBetaling(decimal bedrag, string boodschap)`; `MockBetaalTerminal` in `BetaalSysteemMock` is meegegeven. Bekijk `BetaalSysteemMock.Demo` voor het gebruik: de mock weigert bewust een deel van de betalingen.

**Parkeren en hervatten**

Een klant moet soms even weg, bijvoorbeeld om zijn portefeuille uit de auto te halen. Zijn ticket wordt dan geparkeerd, zodat de kassabediende intussen de volgende klant kan helpen.

- Er kunnen meerdere tickets tegelijk geparkeerd staan.
- Hervatten toont de geparkeerde tickets en laat er één kiezen. Een geparkeerd ticket is herkenbaar aan het **tijdstip waarop het geparkeerd werd**.
- Wordt de kassa afgesloten (het venster gaat dicht), dan gaan geparkeerde tickets die niet meer hervat werden verloren. Dat is ok.

### Het kassaticket op de console

Alle bedragen zijn in **euro**. In de winkel hangt aan het rek de prijs **inclusief btw**: de prijs exclusief btw × (1 + btw-tarief), afgerond op 1 cent. Het ticket werkt met die prijs.

Het kassaticket bevat, conform de wettelijke voorschriften, minstens:

- **naam, adres en ondernemingsnummer** van de verkoper: Mercato 9000, Henleykaai 84, 9000 Gent, ondernemingsnummer 0123.456.789;
- **datum en tijdstip**;
- een **uniek ticketnummer**: het tijdstip tot op de milliseconde, bv. `2026.11.23.09.45.15.123`;
- **per product**: het aantal, de omschrijving, de prijs per stuk en het bedrag (aantal × prijs per stuk), beide **inclusief btw**, en het btw-tarief dat van toepassing is; 
- per toegepast **btw-tarief**: het tarief, de **maatstaf van heffing** (het totaal exclusief btw aan dat tarief) en het **btw-bedrag**;
- het **totaalbedrag inclusief btw**;
- het bedrag **bij contante betaling** (zie hieronder). Dat staat op elk ticket, zodat de klant het al ziet vóór hij betaalt.

De omschrijvingen uit de databank zijn soms lang. Op de console kort je ze in, zodat elk product op één regel past.

**Het ticketnummer** maak je zo:

```csharp
using System.Globalization;

string ticketnummer = DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss.fff", CultureInfo.InvariantCulture);
// bv. "2026.11.23.09.45.15.123"
```

`CultureInfo.InvariantCulture` zorgt dat het resultaat er op elke computer hetzelfde uitziet, ongeacht de taal- en regio-instellingen.

**Afronden.** Elk bedrag dat op het ticket of het klantenscherm komt, wordt afgerond tot op 1 cent (twee cijfers na de komma): is het 3e cijfer na de komma 0 tot 4, dan blijft het 2e cijfer ongewijzigd; is het 5 tot 9, dan wordt het 2e cijfer met 1 verhoogd. Zo wordt € 2,344 € 2,34 en € 2,345 € 2,35.

```csharp
decimal afgerond = Math.Round(bedrag, 2, MidpointRounding.AwayFromZero);
```

- Werk voor bedragen altijd met `decimal`, nooit met `double` of `float`: die kunnen een bedrag als 0,10 niet exact voorstellen.
- Vergeet `MidpointRounding.AwayFromZero` niet. Zonder rondt `Math.Round` een 5 af naar het even cijfer ("bankiersafronding"): `Math.Round(2.345m, 2)` geeft 2,34 in plaats van 2,35.
- Bereken de maatstaf en het btw-bedrag **één keer per tarief**, op het totaal van alle producten aan dat tarief, en niet per productregel.

**Contant betalen.** In België moet het totaalbedrag bij een contante betaling afgerond worden op 0 of 5 cent (wettelijk verplicht sinds 2019). Eindigt het totaal op 1 of 2 cent, dan wordt het naar beneden afgerond; op 3, 4, 6 of 7 cent naar 5 cent; op 8 of 9 cent naar boven. Bij een kaartbetaling wordt niet afgerond.

## Deel 3 — Het klantenscherm

De klant ziet op een tweede scherm wat er gescand wordt. Maak daarvoor een **verzorgde, visueel aantrekkelijke versie van het kassaticket**, zoals je ze een klant zou willen voorschotelen. Hoe ze eruitziet, kiezen jullie zelf: hier kun je met HTML en CSS laten zien wat je kunt.

Het klantenscherm toont altijd het **huidige ticket**, ook als het nog leeg is:

- de producten met hun **volledige omschrijving**, niet ingekort zoals op de console;
- de **prijzen in euro, inclusief btw**, afgerond tot op 1 cent;
- het totaal.

Omschrijvingen kunnen tekens bevatten die in HTML een betekenis hebben, zoals `&` in "Fris & Co". Zorg dat ze correct getoond worden (zie het voorbeeld hieronder). De pagina is bij voorkeur leesbaar op één tot anderhalve meter afstand (op pakweg een 14 inch-scherm).

### Hoe het werkt

In de map `klantscherm` staat `index.html`: een pagina die in de browser toont wat jullie kassa voor de klant wegschrijft, en zichzelf bijwerkt zodra er iets verandert. Aan `index.html` hoef je niets te veranderen. De pagina voor de klant zelf, en de C#-code die ze wegschrijft, maken jullie.

**Opstarten**

1. Open `klantscherm/index.html` in een browser: dubbelklik erop in de Verkenner, of sleep het bestand in een browservenster. Een webserver is niet nodig: de pagina werkt rechtstreeks vanaf je schijf (het adres begint met `file://`).
2. Zet het browservenster **naast** het consolevenster van de kassa, niet op volledig scherm. Zo zie je meteen dat elke wijziging aan het kassaticket op beide schermen verschijnt: de console voor de kassabediende, de browser voor de klant.
3. Start de kassa.

**Wat de kassa moet wegschrijven**

Bij elke wijziging (een scan, een verwijdering, een betaling, ...) schrijft de kassa twee bestanden, allebei in de map `klantscherm`:

| Bestand | Inhoud |
|---|---|
| `klantscherm.html` | Een volledige HTML-pagina (met `<!doctype html>`, `<head>`, `<body>`, ...) met wat de klant op dit moment moet zien. |
| `klantscherm-versie.js` | Eén regel JavaScript die een versie vastlegt: `window.klantschermVersie = "...";`. Tussen de aanhalingstekens staat iets dat **bij elke wijziging anders** is, bv. het tijdstip in ticks of een teller. |

Schrijf eerst de nieuwe `klantscherm.html`, en daarna pas `klantscherm-versie.js` met een **nieuwe** versie, bv.:

```js
window.klantschermVersie = "638987654321234567";
```

`index.html` laadt een paar keer per seconde `klantscherm-versie.js`. Is de versie veranderd, dan laadt het `klantscherm.html` in een onzichtbaar frame, en toont het dat frame pas als de pagina volledig geladen is. Zo flikkert het scherm niet. Daaruit volgt: verander je enkel `klantscherm.html` en niet de versie, dan ziet de klant niets nieuws. En schrijf je de versie vóór de HTML, dan kan `index.html` nog de oude pagina laden.

**Tips**

- **De juiste map vinden.** Een console-app draait vanuit `KassaApp/bin/Debug/net10.0/`. Vanuit `AppContext.BaseDirectory` ga je vier mappen omhoog om bij de map van de solution te komen, en daar zit `klantscherm`.
- **Opmaak.** Zet je CSS in een `<style>`-blok in `klantscherm.html`, of in een apart CSS-bestand in de map `klantscherm` waarnaar je verwijst met een relatief pad (`<link rel="stylesheet" href="klantscherm.css">`). Een vast CSS-bestand hoeft de kassa niet telkens opnieuw te schrijven.
- **Een half geschreven pagina.** Leest de browser het bestand net terwijl de kassa het schrijft, dan kan hij een halve pagina zien. Dat vermijd je door eerst naar een tijdelijk bestand te schrijven en dat daarna in één keer te hernoemen (`File.Move(tijdelijk, doel, overwrite: true)`).
- **Eerst statisch.** Maak de pagina eerst met de hand als `klantscherm.html` met voorbeeldgegevens, en verander telkens de versie in `klantscherm-versie.js` om het resultaat in `index.html` te zien. Pas als ze er goed uitziet, laat je de kassa ze opbouwen.

**Voorbeeld: speciale tekens coderen**

```csharp
using System.Net;

string omschrijving = "Fris & Co <1L>";
string veiligeOmschrijving = WebUtility.HtmlEncode(omschrijving);

string html = $"""
<!doctype html>
<html>
  <body>
    <p>Product: {veiligeOmschrijving}</p>
  </body>
</html>
""";

// Resultaat in de HTML:
// Product: Fris &amp; Co &lt;1L&gt;
```

De browser toont dat als "Product: Fris & Co <1L>". Zonder `HtmlEncode` zou de browser `<1L>` als een (onbekende) HTML-tag lezen en niet tonen.

**Voorbeeld: wegschrijven van de bestanden**

Misschien heb je iets aan volgend fragment...

```csharp
string solutionPad =
        Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", ".."));
string klantschermPad = Path.Combine(solutionPad, "klantscherm");

// eerst: schrijf HTML/CSS weg naar bestand
const string htmlBestand = "klantscherm.html";
string htmlPad = Path.Combine(klantschermPad, htmlBestand);
// ...

// daarna: schrijf versie weg naar bestand
const string versieBestand = "klantscherm-versie.js";
string versiePad = Path.Combine(klantschermPad, versieBestand);
string versie = DateTime.Now.Ticks.ToString();
string inhoud = $"window.klantschermVersie = \"{versie}\";\n";       
string tijdelijk = versiePad + ".tmp";
File.WriteAllText(tijdelijk, inhoud, new UTF8Encoding(false));
File.Move(tijdelijk, versiePad, overwrite: true);
```

## Opleveren

Jullie leveren op via **één private GitHub-repository per groep**. Versiebeheer is in dit project geen doel op zich: het dient als centrale back-up en om op te leveren.

**De repository aanmaken (één keer, door één iemand, maandag)**

1. Open `Kassa.sln` in Visual Studio, op het toestel waar jullie het werk samenbrengen.
2. Kies in het menu **Git → Create Git Repository...**.
3. Kies links **GitHub**, meld je aan met je GitHub-account, en vul in:
   - **Repository name**: kies zelf een gepaste naam, bv. `Mercato9003` bij groep 3;
   - laat **Private repository** aangevinkt.
4. Klik **Create and Push**. Visual Studio maakt de repository op GitHub aan en zet de solution erin, op de branch `main`.
5. Ga op de GitHub-website naar de repository, dan **Settings → Collaborators → Add people**, en voeg toe:
   - alle groepsleden;
   - de lectoren Programmeren Basis: `fdwhogent` en `yanic-hogent`.

   Een collaborator krijgt een uitnodiging per mail; pas als die aanvaard is, heeft hij of zij toegang.

**Pushen (minstens op het einde van elke dag)**

1. Breng eerst het werk van iedereen samen op het centrale toestel.
2. Open in Visual Studio het venster **Git Changes** (menu *View → Git Changes*).
3. Typ een korte beschrijving van wat er veranderd is, en kies **Commit All and Push** (via het pijltje naast *Commit All*).

**Jullie oplevering is wat vrijdag 27 november om 12u30 op de branch `main` (of `master` ) staat.**  Onthoud liever kwaliteit dan volledigheid: een kassa die niet alles kan, maar wat het kan correct doet, is beter dan kunst en vliegwerk, waar jullie geen (code) ownership over hebben, of niet garant kunnen staan voor de kwaliteit van het eindproduct.  Zorg dat elk groepslid alles kan uitleggen en verdedigen.
