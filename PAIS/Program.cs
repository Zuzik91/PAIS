using PAIS_CORE.Database;
using PAIS_CORE.Model;

namespace PAIS
{
    class Program
    {
        static void Main(string[] args)
        {
            var kontaktDb = new Kontakt_MM();
            var uzivatelDb = new Uzivatel_MM();
            var akDb = new AK_MM();
            var poskytovatelDb = new Poskytovatel_MM();
            var doplnkyDb = new Doplnky_MM();

            VytvorKontakty(kontaktDb);
            VytvorUzivatele(uzivatelDb);
            VytvorPoskytovatele(poskytovatelDb);
            VytvorDoplnky(doplnkyDb);
            VytvorAk(akDb, kontaktDb, uzivatelDb, poskytovatelDb, doplnkyDb);

            //PŘIDÁNÍ KONTAKTU
            //PridatKontakt(kontaktDb);
            //Console.WriteLine();

            //SMAZÁNÍ KONTAKTU
            //SmazatKontakt(kontaktDb);
            //Console.WriteLine();

            //VÝPIS VŠECH KONTAKTŮ
            //VypisVsechnyKontakty(kontaktDb);
            //Console.WriteLine();


            /*Console.WriteLine("Ahoj, jmenuji se P.Ai.S a jsem program spravující klienty využívající naše produkty Praetor AI.");
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
                Console.WriteLine();
                string volba = Console.ReadLine().ToUpper();

                switch (volba)
                {
                    case "1": //Práce s advokátní kanceláří
                        while (true)
                        {
                            Console.WriteLine("Volba 1.1 Přidání noví advokátní kanceláře.");
                            Console.WriteLine("Volba 2. ");
                            Console.WriteLine("Volba 3. ");
                            Console.WriteLine("Volba 4. ");
                            Console.WriteLine("Volba 5. ");
                            Console.WriteLine("Volba 6. ");
                            Console.WriteLine("Volba 7. Počet advokátních kanceláří");
                            Console.WriteLine("Volba Q. Ukončit");

                            switch (volba)
                            {
                                case "1":
                                    Console.WriteLine($"Přidali jste nový záznam: ");
                                    Console.WriteLine($"1");
                                    return;

                                case "2":
                                    Console.WriteLine($"2");
                                    Console.WriteLine();
                                    return;

                                case "3":
                                    Console.WriteLine($"3");
                                    Console.WriteLine();
                                    return;

                                case "4":
                                    Console.WriteLine($"4");
                                    Console.WriteLine();
                                    return;

                                case "5":
                                    Console.WriteLine($"5");
                                    Console.WriteLine();
                                    return;

                                case "6":
                                    Console.WriteLine($"6");
                                    Console.WriteLine();
                                    return;

                                case "7": //Počet advokátních kanceláří
                                    Console.WriteLine($"Počet advokátních kanceláří je {akDb.PocetZaznamu()}");
                                    Console.WriteLine();
                                    return;

                                case "Q":
                                    Console.WriteLine();
                                    break;

                                default:
                                    Console.WriteLine();
                                    return;
                            }

                        }

                    case "2": //Práce s uživateli
                        break;

                    case "3": //Práce s kontakty
                        Console.WriteLine("Volba 3.1 Přidání nového kontaktu.");
                        Console.WriteLine("Volba 3.2 ");
                        Console.WriteLine("Volba 3.3 ");
                        Console.WriteLine("Volba 3.4 ");
                        Console.WriteLine("Volba 3.5 ");
                        Console.WriteLine("Volba 3.6 ");
                        Console.WriteLine("Volba 3.7 Počet kontaktů (celkem).");
                        Console.WriteLine("Volba Q. Ukončit");

                        switch (volba)
                        {
                            case "3.1":
                                PridatKontakt(kontaktDb);
                                Console.WriteLine();
                                return;

                            case "3.2":
                                Console.WriteLine($"2");
                                Console.WriteLine("Zadali jste špatný údaj");
                                return;

                            case "3.3":
                                Console.WriteLine($"3");
                                Console.WriteLine();
                                return;

                            case "3.4":
                                Console.WriteLine($"4");
                                Console.WriteLine();
                                return;

                            case "3.5":
                                Console.WriteLine($"5");
                                Console.WriteLine();
                                return;

                            case "3.6":
                                Console.WriteLine($"6");
                                Console.WriteLine();
                                return;

                            case "3.7": //Počet kontaktů (celkem)
                                Console.WriteLine($"Počet kontaktů celkem je {akDb.PocetZaznamu()}");
                                Console.WriteLine();
                                return;

                            case "Q":
                                Console.WriteLine();
                                break;
                        }
                        break;

                    case "Q":
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Zadali jste špatný symbol");
                        Console.WriteLine();
                        break;
                }
            }*/
        }

        static void VytvorKontakty(Kontakt_MM kontaktDb)
        {
            var kontakt = new Kontakt("Pepa", "Šmíd", "123456789", "smid@smid.cz");
            kontaktDb.Vloz(kontakt);
            kontakt = new Kontakt("Alena", "Šilerová", "234567891", "shilerka@shilerka.com");
            kontaktDb.Vloz(kontakt);
            kontakt = new Kontakt("Martin", "Novák", "345678912", "novak@novak.cz");
            kontaktDb.Vloz(kontakt);
            kontakt = new Kontakt("Zuzana", "Čermochová", "456789123", "cermochova@cermochova.com");
            kontaktDb.Vloz(kontakt);
            kontakt = new Kontakt("Ondřej", "Huml", "567891234", "huml@huml.cz");
            kontaktDb.Vloz(kontakt);
        }

        static void VytvorUzivatele(Uzivatel_MM uzivatelDb)
        {
            var uzivatel = new Uzivatel("Pepa", "Šmíd", "123456789", "smid@smid.cz", "sk_123456");
            uzivatelDb.Vloz(uzivatel);
            uzivatel = new Uzivatel("Alena", "Šilerová", "234567891", "shilerka@shilerka.com", "sk_234567");
            uzivatelDb.Vloz(uzivatel);
            uzivatel = new Uzivatel("Martin", "Novák", "345678912", "novak@novak.cz", "sk_345678");
            uzivatelDb.Vloz(uzivatel);
            uzivatel = new Uzivatel("Zuzana", "Čermochová", "456789123", "cermochova@cermochova.com", "sk_456789");
            uzivatelDb.Vloz(uzivatel);
            uzivatel = new Uzivatel("Ondřej", "Huml", "567891234", "huml@huml.cz", "sk_567891");
            uzivatelDb.Vloz(uzivatel);
        }

        static void VytvorAk(AK_MM akDb, Kontakt_MM kontaktDb, Uzivatel_MM uzivatelDb, Poskytovatel_MM poskytovatelDb, Doplnky_MM doplnkyDb)
        {
            var uzivatele = new List<Uzivatel>();
            uzivatele.Add(uzivatelDb.Ziskej(1));
            uzivatele.Add(uzivatelDb.Ziskej(2));

            var poskytovatele = new List<Poskytovatel>();
            poskytovatele.Add(poskytovatelDb.Ziskej(1));

            var ak = new AK("AK Smid", kontaktDb.Ziskej(1), uzivatele, poskytovatele, doplnkyDb.Ziskej(1), "paojfohwe", "wfiagffi", "smid");
            akDb.Vloz(ak);
        }

        static void VytvorPoskytovatele(Poskytovatel_MM poskytovatelDb)
        {
            var poskytovatel = new Poskytovatel(TypPoskytovatele.OpenAI, "cz_1a2b3c4d5e6f", "https://abc");
            poskytovatelDb.Vloz(poskytovatel);
            poskytovatel = new Poskytovatel(TypPoskytovatele.Azure, "cz_2b3c4d5e6f7g", "https://bcd");
            poskytovatelDb.Vloz(poskytovatel);
        }

        static void VytvorDoplnky(Doplnky_MM doplnkyDb)
        {
            var doplnky = new Doplnky(true, true, true, true, true);
            doplnkyDb.Vloz(doplnky);
            doplnky = new Doplnky(true, false, true, true, true);
            doplnkyDb.Vloz(doplnky);
            doplnky = new Doplnky(true, false, false, false, true);
            doplnkyDb.Vloz(doplnky);

        }

        static void PridatKontakt(Kontakt_MM kontaktDb)
        {
            try
            {
                Console.WriteLine("Zadejte jméno:");
                string jmeno = Console.ReadLine();

                Console.WriteLine("Zadejte příjmení:");
                string prijmeni = Console.ReadLine();

                Console.WriteLine("Zadejte telefonní číslo:");
                string telefonniCislo = Console.ReadLine();

                Console.WriteLine("Zadejte email:");
                string email = Console.ReadLine();

                if (kontaktDb.ExistujeKontakt(telefonniCislo, email))
                {
                    Console.WriteLine("Kontakt s tímto telefonním číslem nebo emailem již existuje.");
                    return;
                }

                var kontakt = new Kontakt(jmeno, prijmeni, telefonniCislo, email);
                kontaktDb.Vloz(kontakt);

                Console.WriteLine($"Přidali jste nový kontakt: {kontakt.ToString()}");

                VypisVsechnyKontakty(kontaktDb);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Telefonní číslo musí obsahovat pouze čísla a mít délku 9 až 15 čísel!");
            }
        }

        static void VypisVsechnyKontakty(Kontakt_MM kontaktDb)
        {
            var kontakty = kontaktDb.ZiskejVsechny();
            Console.WriteLine("Seznam všech kontaktů:");
            foreach (var kontakt in kontakty)
            {
                Console.WriteLine(kontakt.ToString());
            }
        }

        static void SmazatKontakt(Kontakt_MM kontaktDb)
        {
            Console.WriteLine("Zadejte ID kontaktu, který chcete smazat:");
            int id = int.Parse(Console.ReadLine());

            kontaktDb.Smaz(id);

            VypisVsechnyKontakty(kontaktDb);
        }

    }
}