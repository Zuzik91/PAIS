using PAIS_CORE.Database;
using PAIS_CORE.Model;

namespace PAIS
{
    class Program
    {
        static void Main(string[] args)
        {
            var kontaktDb = new Kontakt_DB();
            var uzivatelDb = new Uzivatel_DB();
            var akDb = new AK_DB();
            var poskytovatelDb = new Poskytovatel_DB();
            var doplnkyDb = new Doplnky_DB();

            VytvorKontakty(kontaktDb);
            VytvorUzivatele(uzivatelDb);
            VytvorPoskytovatele(poskytovatelDb);
            VytvorDoplnky(doplnkyDb);
            VytvorAk(akDb, kontaktDb, uzivatelDb, poskytovatelDb, doplnkyDb);
            

            Console.WriteLine("Ahoj, jmenuji se P.Ai.S a jsem program spravující klienty využívající naše produkty Praetor AI.");
            Console.WriteLine($"Našimi doplňky jsou: Word AI, Outlook AI, Integrace, Analýza a Anonymizace.");
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

                if (string.Equals(volba, "Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else if (volba == "1") //Práce s advokátní kanceláří
                {
                    Console.WriteLine("Volba 1. Počet advokátních kanceláří");
                    Console.WriteLine("Volba 2. ");
                    Console.WriteLine("Volba 3. ");
                    Console.WriteLine("Volba 4. ");
                    Console.WriteLine("Volba 5. ");
                    Console.WriteLine("Volba 6. ");
                    Console.WriteLine("Volba 7. ");
                    Console.WriteLine("Volba Q. Ukončit");
                    volba = Console.ReadLine();

                    if (volba == "1") //Počet advokátních kanceláří
                    {
                        Console.WriteLine($"Počet advokátních kanceláří je {akDb.PocetZaznamu()}");
                    }
                    /*else if (volba == "2")
                    {
                        if ()
                        {
                            Console.WriteLine($"2");
                        }
                        else
                        {
                            Console.WriteLine("Zadali jste špatný údaj");
                        }
                    }*/
                    else if (volba == "3")
                    {
                        Console.WriteLine($"3");
                    }
                    else if (volba == "4")
                    {
                        Console.WriteLine($"4");
                    }
                    else if (volba == "5")
                    {
                        Console.WriteLine($"5");
                    }
                    else if (volba == "6")
                    {
                        Console.WriteLine($"6");
                    }
                    else if (volba == "7")
                    {
                        Console.WriteLine($"7");
                    }
                    else if (string.Equals(volba, "Q", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Zadali jste špatný symbol");
                    }
                }
                else if (volba == "2") //Práce s uživateli
                {
                    Console.WriteLine("Volba 1. Počet uživatelů v advokátní kanceláři");
                    Console.WriteLine("Volba 2. ");
                    Console.WriteLine("Volba 3. ");
                    Console.WriteLine("Volba 4. ");
                    Console.WriteLine("Volba 5. ");
                    Console.WriteLine("Volba 6. ");
                    Console.WriteLine("Volba 7. ");
                    Console.WriteLine("Volba Q. Ukončit");
                    volba = Console.ReadLine();

                    if (volba == "1")
                    {
                        Console.WriteLine($"Počet uživatelů je {uzivatelDb.PocetZaznamu()}");
                    }
                    else if (volba == "2")
                    {
                        Console.WriteLine($"2");
                    }
                    else if (volba == "3")
                    {
                        Console.WriteLine($"3");
                    }
                    else if (volba == "4")
                    {
                        Console.WriteLine($"4");
                    }
                    else if (volba == "5")
                    {
                        Console.WriteLine($"5");
                    }
                    else if (volba == "6")
                    {
                        Console.WriteLine($"6");
                    }
                    else if (volba == "7")
                    {
                        Console.WriteLine($"7");
                    }
                    else if (string.Equals(volba, "Q", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Zadali jste špatný symbol");
                    }
                }
                else if (volba == "3") //Práce s kontakty
                {
                    Console.WriteLine("Volba 1. Počet kontaktů");
                    Console.WriteLine("Volba 2. ");
                    Console.WriteLine("Volba 3. ");
                    Console.WriteLine("Volba 4. ");
                    Console.WriteLine("Volba 5. ");
                    Console.WriteLine("Volba 6. ");
                    Console.WriteLine("Volba 7. ");
                    Console.WriteLine("Volba Q. Ukončit");
                    volba = Console.ReadLine();

                    if (volba == "1")
                    {
                        Console.WriteLine($"Počet kontaktů je {kontaktDb.PocetZaznamu()}");
                    }
                    else if (volba == "2")
                    {
                        Console.WriteLine($"2");
                    }
                    else if (volba == "3")
                    {
                        Console.WriteLine($"3");
                    }
                    else if (volba == "4")
                    {
                        Console.WriteLine($"4");
                    }
                    else if (volba == "5")
                    {
                        Console.WriteLine($"5");
                    }
                    else if (volba == "6")
                    {
                        Console.WriteLine($"6");
                    }
                    else if (volba == "7")
                    {
                        Console.WriteLine($"7");
                    }
                    else if (string.Equals(volba, "Q", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Zadali jste špatný symbol");
                    }
                }
                else if (volba == "4") //Práce s poskytovateli
                {
                    Console.WriteLine("Volba 1. Počet poskytovatelů");
                    Console.WriteLine("Volba 2. ");
                    Console.WriteLine("Volba 3. ");
                    Console.WriteLine("Volba 4. ");
                    Console.WriteLine("Volba 5. ");
                    Console.WriteLine("Volba 6. ");
                    Console.WriteLine("Volba 7. ");
                    Console.WriteLine("Volba Q. Ukončit");
                    volba = Console.ReadLine();

                    if (volba == "1")
                    {
                        Console.WriteLine($"Počet poskytovatelů je {poskytovatelDb.PocetZaznamu()}");
                    }
                    else if (volba == "2")
                    {
                        Console.WriteLine($"2");
                    }
                    else if (volba == "3")
                    {
                        Console.WriteLine($"3");
                    }
                    else if (volba == "4")
                    {
                        Console.WriteLine($"4");
                    }
                    else if (volba == "5")
                    {
                        Console.WriteLine($"5");
                    }
                    else if (volba == "6")
                    {
                        Console.WriteLine($"6");
                    }
                    else if (volba == "7")
                    {
                        Console.WriteLine($"7");
                    }
                    else if (string.Equals(volba, "Q", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Zadali jste špatný symbol");
                    }

                }
                else if (volba == "5") //Práce s doplňky
                {
                    Console.WriteLine("Volba 1. Počet doplňků");
                    Console.WriteLine("Volba 2. ");
                    Console.WriteLine("Volba 3. ");
                    Console.WriteLine("Volba 4. ");
                    Console.WriteLine("Volba 5. ");
                    Console.WriteLine("Volba 6. ");
                    Console.WriteLine("Volba 7. ");
                    Console.WriteLine("Volba Q. Ukončit");
                    volba = Console.ReadLine();

                    if (volba == "1")
                    {
                        Console.WriteLine($"Počet doplňků je {doplnkyDb.PocetZaznamu()}");
                    }
                    else if (volba == "2")
                    {
                        Console.WriteLine($"2");
                    }
                    else if (volba == "3")
                    {
                        Console.WriteLine($"3");
                    }
                    else if (volba == "4")
                    {
                        Console.WriteLine($"4");
                    }
                    else if (volba == "5")
                    {
                        Console.WriteLine($"5");
                    }
                    else if (volba == "6")
                    {
                        Console.WriteLine($"6");
                    }
                    else if (volba == "7")
                    {
                        Console.WriteLine($"7");
                    }
                    else if (string.Equals(volba, "Q", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Zadali jste špatný symbol");
                    }
                }
            }
        }

        static void VytvorKontakty(Kontakt_DB kontaktDb)
        {
            var kontakt = new Kontakt("Pepa", "Šmíd", 123456789, "smid@smid.cz");
            kontaktDb.Vloz(kontakt);
            kontakt = new Kontakt("Alena", "Šilerová", 234567891, "shilerka@shilerka.com");
            kontaktDb.Vloz(kontakt);
            kontakt = new Kontakt("Martin", "Novák", 345678912, "novak@novak.cz");
            kontaktDb.Vloz(kontakt);
            kontakt = new Kontakt("Zuzana", "Čermochová", 456789123, "cermochova@cermochova.com");
            kontaktDb.Vloz(kontakt);
            kontakt = new Kontakt("Ondřej", "Huml", 567891234, "huml@huml.cz");
            kontaktDb.Vloz(kontakt);
        }

        static void VytvorUzivatele(Uzivatel_DB uzivatelDb)
        {
            var uzivatel = new Uzivatel("Pepa", "Šmíd", 123456789, "smid@smid.cz", "sk_123456");
            uzivatelDb.Vloz(uzivatel);
            uzivatel = new Uzivatel("Alena", "Šilerová", 234567891, "shilerka@shilerka.com", "sk_234567");
            uzivatelDb.Vloz(uzivatel);
            uzivatel = new Uzivatel("Martin", "Novák", 345678912, "novak@novak.cz", "sk_345678");
            uzivatelDb.Vloz(uzivatel);
            uzivatel = new Uzivatel("Zuzana", "Čermochová", 456789123, "cermochova@cermochova.com", "sk_456789");
            uzivatelDb.Vloz(uzivatel);
            uzivatel = new Uzivatel("Ondřej", "Huml", 567891234, "huml@huml.cz", "sk_567891");
            uzivatelDb.Vloz(uzivatel);
        }

        static void VytvorAk(AK_DB akDb, Kontakt_DB kontaktDb, Uzivatel_DB uzivatelDb, Poskytovatel_DB poskytovatelDb, Doplnky_DB doplnkyDb)
        {
            var uzivatele = new List<Uzivatel>();
            uzivatele.Add(uzivatelDb.Ziskej(1));
            uzivatele.Add(uzivatelDb.Ziskej(2));

            var poskytovatele = new List<Poskytovatel>();
            poskytovatele.Add(poskytovatelDb.Ziskej(1));

            var ak = new AK("AK Smid", kontaktDb.Ziskej(1), uzivatele, poskytovatele, doplnkyDb.Ziskej(1), "paojfohwe", "wfiagffi", "smid");
            akDb.Vloz(ak);
        }

        static void VytvorPoskytovatele(Poskytovatel_DB poskytovatelDb)
        {
            var poskytovatel = new Poskytovatel(TypPoskytovatele.OpenAI, "cz_1a2b3c4d5e6f", "https://abc");
            poskytovatelDb.Vloz(poskytovatel);
            poskytovatel = new Poskytovatel(TypPoskytovatele.Azure, "cz_2b3c4d5e6f7g", "https://bcd");
            poskytovatelDb.Vloz(poskytovatel);
        }

        static void VytvorDoplnky(Doplnky_DB doplnkyDb)
        {
            var doplnky = new Doplnky(true, true, true, true, true);
            doplnkyDb.Vloz(doplnky);
            doplnky = new Doplnky(true, false, true, true, true);
            doplnkyDb.Vloz(doplnky);
            doplnky = new Doplnky(true, false, false, false, true);
            doplnkyDb.Vloz(doplnky);

        }
    }
}