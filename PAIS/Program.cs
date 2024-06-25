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

            //VÝPIS DOPLŇKŮ DANNÉ AK 
            //VypisDoplnkyAK(akDb);

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
                Console.WriteLine();
                string volba = Console.ReadLine().ToUpper();

                switch (volba)
                {
                    case "1": //Práce s advokátní kanceláří
                        PracujAdvokatniKancelar(akDb, kontaktDb, uzivatelDb, poskytovatelDb, doplnkyDb);
                        break;

                    case "2": //Práce s uživateli
                        PracujUzivateli(uzivatelDb);
                        break;

                    case "3": //Práce s kontakty
                        PracujKontaky(kontaktDb);
                        break;

                    case "4": //Práce s poskytovateli
                        PracujPoskytovateli(poskytovatelDb);
                        break;

                    case "5": //Práce s doplňky
                        PracujDoplnky(doplnkyDb);
                        break;

                    case "Q":
                        return;

                    default:
                        Console.WriteLine("Zadali jste špatný symbol.");
                        Console.WriteLine();
                        break;
                }
            }
        }

        private static void PracujDoplnky(Doplnky_MM doplnkyDb)
        {
            while (true)
            {
                Console.WriteLine("Volba 5.1 Výpis všech doplňků");
                Console.WriteLine("Volba Q. Ukončit");
                Console.WriteLine();
                string volba = Console.ReadLine().ToUpper();
                Console.WriteLine();

                switch (volba)
                {
                    case "5.1":
                        VypisVsechnyDoplnky(doplnkyDb);
                        Console.WriteLine();
                        break;

                    case "Q":
                        Console.WriteLine();
                        return;
                }
            }
        }

        private static void PracujPoskytovateli(Poskytovatel_MM poskytovatelDb)
        {
            while (true)
            {
                Console.WriteLine("Volba 4.1 Výpis všech poskytovatelů");
                Console.WriteLine("Volba 4.2 Počet poskytovatelů (celkem)");
                Console.WriteLine("Volba Q. Ukončit");
                Console.WriteLine();
                string volba = Console.ReadLine().ToUpper();

                switch (volba)
                {
                    case "4.1":
                        VypisVsechnyPoskytovatele(poskytovatelDb);
                        Console.WriteLine();
                        break;

                    case "4.2":
                        Console.WriteLine($"Počet poskytovatelů celkem je {poskytovatelDb.PocetZaznamu()}.");
                        Console.WriteLine();
                        break;

                    case "Q":
                        Console.WriteLine();
                        return;
                }
            }
        }

        private static void PracujKontaky(Kontakt_MM kontaktDb)
        {
            while (true)
            {
                Console.WriteLine("Volba 3.1 Přidání nového kontaktu");
                Console.WriteLine("Volba 3.2 Smazání kontaktu");
                Console.WriteLine("Volba 3.3 Výpis všech kontaktů");
                Console.WriteLine("Volba 3.4 Počet kontaktů (celkem)");
                Console.WriteLine("Volba Q. Ukončit");
                Console.WriteLine();
                string volba = Console.ReadLine().ToUpper();

                switch (volba)
                {
                    case "3.1":
                        PridatKontakt(kontaktDb);
                        Console.WriteLine();
                        break;

                    case "3.2":
                        SmazatKontakt(kontaktDb);
                        Console.WriteLine();
                        break;

                    case "3.3":
                        VypisVsechnyKontakty(kontaktDb);
                        Console.WriteLine();
                        break;

                    case "3.4": //Počet kontaktů (celkem)
                        Console.WriteLine($"Počet kontaktů celkem je {kontaktDb.PocetZaznamu()}.");
                        Console.WriteLine();
                        break;

                    case "Q":
                        Console.WriteLine();
                        return;
                }
            }
        }

        private static void PracujUzivateli(Uzivatel_MM uzivatelDb)
        {
            while (true)
            {
                Console.WriteLine("Volba 2.1 Přidání nového uživatele");
                Console.WriteLine("Volba 2.2 Smazání uživatele");
                Console.WriteLine("Volba 2.3 Výpis všech uživatelů");
                Console.WriteLine("Volba 2.4 Počet uživatelů (celkem)");
                Console.WriteLine("Volba Q. Ukončit");
                Console.WriteLine();
                string volba = Console.ReadLine().ToUpper();

                switch (volba)
                {
                    case "2.1":
                        PridatUzivatel(uzivatelDb);
                        Console.WriteLine();
                        break;

                    case "2.2":
                        SmazatUzivatel(uzivatelDb);
                        Console.WriteLine();
                        break;

                    case "2.3":
                        VypisVsechnyUzivatele(uzivatelDb);
                        Console.WriteLine();
                        break;

                    case "2.4":
                        Console.WriteLine($"Počet uživatelů celkem je {uzivatelDb.PocetZaznamu()}.");
                        Console.WriteLine();
                        break;

                    case "Q":
                        Console.WriteLine();
                        return;
                }
            }
        }

        private static void PracujAdvokatniKancelar(AK_MM akDb, Kontakt_MM kontaktyDb, Uzivatel_MM uzivatelDb, Poskytovatel_MM poskytovateleDb, Doplnky_MM doplnkyDb)
        {
            while (true)
            {
                Console.WriteLine("Volba 1.1 Přidání nové advokátní kanceláře");
                Console.WriteLine("Volba 1.2 Smazání advokátní kanceláře");
                Console.WriteLine("Volba 1.3 Výpis všech advokátních kanceláří");
                Console.WriteLine("Volba 1.4 Počet advokátních kanceláří");
                Console.WriteLine("Volba 1.5 Vypiš doplňky u konkrétní advokátní kanceláře");
                Console.WriteLine("Volba Q. Ukončit");
                Console.WriteLine();
                string volba = Console.ReadLine().ToUpper();

                switch (volba)
                {
                    case "1.1":
                        PridatAk(akDb, kontaktyDb, uzivatelDb, poskytovateleDb, doplnkyDb);
                        Console.WriteLine();
                        break;

                    case "1.2":
                        SmazatAk(akDb);
                        Console.WriteLine();
                        break;

                    case "1.3":
                        VypisVsechnyAk(akDb);
                        Console.WriteLine();
                        break;

                    case "1.4":
                        Console.WriteLine($"Celkový počet advokátních kanceláří je {akDb.PocetZaznamu()}.");
                        Console.WriteLine();
                        break;

                    case "1.5":
                        VypisDoplnkyAK(akDb);
                        Console.WriteLine();
                        break;

                    case "Q":
                        Console.WriteLine();
                        return;
                }

            }
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

            var ak = new AK("AK Smid", kontaktDb.Ziskej(1), uzivatele, poskytovatele, doplnkyDb.Ziskej(1), "https://xyz", "https://ai.praetor.app/x", "smid");
            akDb.Vloz(ak);
            ak = new AK("AK Novák", kontaktDb.Ziskej(1), uzivatele, poskytovatele, doplnkyDb.Ziskej(1), "https://efg", "https://ai.praetor.app/e", "novak");
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

        static void VypisDoplnkyAK(AK_MM akDb)
        {
            Console.WriteLine("Napiš název serveru advokátní kanceláře:");
            string nazevServeru = Console.ReadLine();

            if (akDb.ExistujeAk(nazevServeru))
            {
                var ak = akDb.ZiskejVsechny();
                foreach (var a in ak)
                {
                    if (a.NazevServeru == nazevServeru)
                    {
                        var doplnky = a.Doplnky;
                        Console.WriteLine($"{a.NazevAk} má následující doplňky: {doplnky.ToString()}");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Advokátní kancelář s názvem serveru \"{nazevServeru}\" neexistuje.");
            }
        }

        static void VypisVsechnyDoplnky(Doplnky_MM doplnkyDb)
        {
            var doplnky = doplnkyDb.ZiskejVsechny();
            Console.WriteLine("Seznam všech doplňků:");
            foreach (var doplnek in doplnky)
            {
                Console.WriteLine(doplnek.ToString());
                break;
            }
        }

        static void VypisVsechnyPoskytovatele(Poskytovatel_MM poskytovatelDb)
        {
            var poskytovatel = poskytovatelDb.ZiskejVsechny();
            Console.WriteLine("Seznam všech poskytovatelů:");
            foreach (var poskytovatele in poskytovatel)
            {
                Console.WriteLine(poskytovatele.ToString());
            }
        }

        static void PridatUzivatel(Uzivatel_MM uzivatelDb)
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

                Console.WriteLine("Zadejte API Token uživatele:");
                string apiTokenUzivatele = Console.ReadLine();

                if (uzivatelDb.ExistujeUzivatel(apiTokenUzivatele))
                {
                    Console.WriteLine("Uživatel s tímto tokenem existuje.");
                    return;
                }

                var uzivatel = new Uzivatel(jmeno, prijmeni, telefonniCislo, email, apiTokenUzivatele);
                uzivatelDb.Vloz(uzivatel);

                Console.WriteLine($"Přidali jste nového uživatele: {uzivatel.ToString()}");

                VypisVsechnyUzivatele(uzivatelDb);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Telefonní číslo musí obsahovat pouze čísla a mít délku 9 až 15 čísel!");
            }
        }

        static void VypisVsechnyUzivatele(Uzivatel_MM uzivatelDb)
        {
            var uzivatel = uzivatelDb.ZiskejVsechny();
            Console.WriteLine("Seznam všech uživatelů:");
            foreach (var uzivatele in uzivatel)
            {
                Console.WriteLine(uzivatele.ToString());
            }
        }

        static void SmazatUzivatel(Uzivatel_MM uzivatelDb)
        {
            Console.WriteLine("Zadejte ID uživatele, kterého chcete smazat:");
            int id = int.Parse(Console.ReadLine());

            uzivatelDb.Smaz(id);

            VypisVsechnyUzivatele(uzivatelDb);
        }

        static void VypisVsechnyAk(AK_MM akDb)
        {
            var ak = akDb.ZiskejVsechny();
            Console.WriteLine("Seznam všech advokátních kanceláří:");
            foreach (var a in ak)
            {
                Console.WriteLine(a.ToString());
            }
        }

        static void SmazatAk(AK_MM akDb)
        {
            Console.WriteLine("Zadejte ID advokátní kanceláře, kterou chcete smazat:");
            int id = int.Parse(Console.ReadLine());

            akDb.Smaz(id);

            VypisVsechnyAk(akDb);
        }

        static void PridatAk(AK_MM akDb, Kontakt_MM kontaktyDb, Uzivatel_MM uzivatelDb, Poskytovatel_MM poskytovateleDb, Doplnky_MM doplnkyDb)
        {
            try
            {
                Console.WriteLine("Zadejte název advokátní kanceláře:");
                string nazevAk = Console.ReadLine();

                Console.WriteLine("Zadejte Id kontaktní osoby:");
                int kontaktniOsobaId = int.Parse(Console.ReadLine());
                Kontakt kontaktniOsoba = kontaktyDb.Ziskej(kontaktniOsobaId);

                Console.WriteLine("Zadejte Id uživatelů oddělené čárkou:");
                string uzivatele = Console.ReadLine();
                List<Uzivatel> seznamUzivatelu = new List<Uzivatel>();
                //1,2
                foreach (var uzivatelId in uzivatele.Split(','))
                {
                    int uzivatelIdInt = int.Parse(uzivatelId.Trim());
                    Uzivatel uzivatel = uzivatelDb.Ziskej(uzivatelIdInt);
                    seznamUzivatelu.Add(uzivatel);
                }

                Console.WriteLine("Zadejte Id poskytovatelů oddělené čárkou:");
                string poskytovatele = Console.ReadLine();
                List<Poskytovatel> seznamPoskytovatelu = new List<Poskytovatel>();
                //1,2
                foreach (var poskytovatelId in poskytovatele.Split(','))
                {
                    int poskytovatelIdInt = int.Parse(poskytovatelId.Trim());
                    Poskytovatel poskytovatel = poskytovateleDb.Ziskej(poskytovatelIdInt);
                    seznamPoskytovatelu.Add(poskytovatel);
                }

                Console.WriteLine("Zadejte Id doplňků:");
                int doplnkyId = int.Parse(Console.ReadLine());
                Doplnky doplnky = doplnkyDb.Ziskej(doplnkyId);

                Console.WriteLine("Zadejte přiřazenou googlovskou tabulku:");
                string googlovskaTabulka = Console.ReadLine();

                Console.WriteLine("Zadejte přiřazenou webovou aplikaci:");
                string praetorAiService = Console.ReadLine();

                Console.WriteLine("Zadejte název serveru:");
                string nazevServeru = Console.ReadLine();

                if (akDb.ExistujeAk(nazevServeru))
                {
                    Console.WriteLine("Tato advokátní kacelář již existuje.");
                    return;
                }

                var ak = new AK(nazevAk, kontaktniOsoba, seznamUzivatelu, seznamPoskytovatelu, doplnky, googlovskaTabulka, praetorAiService, nazevServeru);
                akDb.Vloz(ak);

                Console.WriteLine($"Přidali jste novou advokátní kancelář: {ak.ToString()}");

                VypisVsechnyAk(akDb);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Telefonní číslo musí obsahovat pouze čísla a mít délku 9 až 15 čísel!");
            }
        }
    }
}