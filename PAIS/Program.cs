using PAIS_CORE.Database;
using PAIS_CORE.Model;

var akDb = new AK_DB();

var uzivatelDb = new Uzivatel_DB();

var uzivatel = new Uzivatel(0, "Pepa", "Šmíd", 123456789, "smid@smid.cz", "sk_123456");
uzivatelDb.Vloz(uzivatel);
var uzivatel2 = new Uzivatel(0, "Alena", "Šilerova", 123456789, "shilerka@smid.cz", "sk_123456");
uzivatelDb.Vloz(uzivatel2);

var kontaktDb = new Kontakt_DB();

var poskytovatelDb = new Poskytovatel_DB();

var doplnkyDb = new Doplnky_DB();

Console.WriteLine("Ahoj, jmenuji se P.Ai.S a jsem program spravující klienty využívající naše produkty Praetor AI.");
// Console.WriteLine($"Našimi doplňky jsou: {Doplnky.ZiskejVsechny}.");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Volba 1. Práce s advokátní kanceláří");
    Console.WriteLine("Volba 2. Práce s uživateli");
    Console.WriteLine("Volba 3. Práce s kontakty");
    Console.WriteLine("Volba 4. Práce s poskytovateli");
    Console.WriteLine("Volba 5. Práce s doplňky");
    Console.WriteLine("Volba Q. Ukončit");
    string volba = Console.ReadLine();
    if (volba == "Q" (StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    else if (volba == "1")
    {
        Console.WriteLine("Volba 1. Počet advokátních kanceláří");
        Console.WriteLine("Volba 2. Odebrat advokátní kancelář");
        Console.WriteLine("Volba Q. Ukončit");
        volba = Console.ReadLine();

        if (volba == "1")
        {
            Console.WriteLine($"Počet advokátních kanceláří je {akDb.PocetZaznamu()}");
        }
        else if (volba == "Q" && volba == "q")
        {
            break;
        }
    }
    else if (volba == "2") //přiřadit uživatele pod advokátní kancelář
    {
        Console.WriteLine("Volba 1. Počet uživatelů v advokátní kanceláři");
        Console.WriteLine("Volba 2. Odebrat uživatele");
        Console.WriteLine("Volba Q. Ukončit");
        volba = Console.ReadLine();

        if (volba == "1")
        {
            Console.WriteLine($"Počet uživatelů je {uzivatelDb.PocetZaznamu()}");
        }
        else if (volba == "Q" && volba == "q")
        {
            break;
        }

    }
    else if (volba == "3")
    {
        Console.WriteLine("Volba 1. Počet kontaktů");
        Console.WriteLine("Volba 2. Odebrat kontakt");
        Console.WriteLine("Volba Q. Ukončit");
        volba = Console.ReadLine();

        if (volba == "1")
        {
            Console.WriteLine($"Počet kontaktů je {kontaktDb.PocetZaznamu()}");
        }
        else if (volba == "Q" && volba == "q")
        {
            break;
        }

    }
    else if (volba == "4")
    {
        Console.WriteLine("Volba 1. Počet poskytovatelů");
        Console.WriteLine("Volba 2. Odebrat poskytovatele");
        Console.WriteLine("Volba Q. Ukončit");
        volba = Console.ReadLine();

        if (volba == "1")
        {
            Console.WriteLine($"Počet poskytovatelů je {poskytovatelDb.PocetZaznamu()}");
        }
        else if (volba == "Q" && volba == "q")
        {
            break;
        }

    }
    else if (volba == "5")
    {
        Console.WriteLine("Volba 1. Počet doplňků");
        Console.WriteLine("Volba 2. Odebrat doplněk");
        Console.WriteLine("Volba Q. Ukončit");
        volba = Console.ReadLine();

        if (volba == "1")
        {
            Console.WriteLine($"Počet doplňků je {doplnkyDb.PocetZaznamu()}");
        }
        else if (volba == "Q" && volba == "q")
        {
            break;
        }
    }
}


//var text = "abcd";
//var delka = text.Length;

//var text2 = new string('a', 5);
//var delka2 = text2.Length;
//int pocatek = 0;
//int pocetZnaku = 2;
//var text3 = text.Substring(pocatek, pocetZnaku);
//Console.WriteLine(text3);
