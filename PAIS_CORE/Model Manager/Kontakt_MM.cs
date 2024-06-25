using PAIS_CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Database
{
    public class Kontakt_MM : IMm<Kontakt>
    {
        private static Dictionary<int, Kontakt> db = new Dictionary<int, Kontakt>();

        private static int posledniId = 1;

        public void Vloz(Kontakt kontakt)
        {
            if (kontakt.Id != 0 && db.ContainsKey(kontakt.Id))
            {
                Console.WriteLine($"Kontakt {kontakt.Jmeno} {kontakt.Prijmeni} již existuje");
            }
            else
            {
                kontakt.Id = posledniId++;
                db.Add( kontakt.Id, kontakt);
            }
        }

        public void Smaz(Kontakt kontakt)
        {
            Smaz(kontakt.Id);
        }

        public void Smaz(int id)
        {
            if (db.ContainsKey(id))
            {
                db.Remove(id);
            }
            else
            {
                Console.WriteLine($"Kontakt s id {id} není v databázi.");
            }
        }

        public void Aktualizuj(Kontakt kontakt)
        {
            int id = kontakt.Id;
            db[id] = (kontakt);
        }

        public Kontakt Ziskej(int id)
        {
           var kontakt = db[id];
            return kontakt;
        }

        public List<Kontakt> ZiskejVsechny()
        {
            List<Kontakt> vysledek = new List<Kontakt>();
            foreach(var kontakt in db)
            {
                var abc = kontakt.Value;
                vysledek.Add(abc);
            }

            return vysledek;
        }
        public int PocetZaznamu()
        {
            return db.Count;
        }

        void PridatKontakt()
        {
            Console.WriteLine("Zadejte jméno:");
            string jmeno = Console.ReadLine();

            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine();

            Console.WriteLine("Zadejte telefonní číslo:");
            string telefonniCislo = (Console.ReadLine());

            Console.WriteLine("Zadejte email:");
            string email = Console.ReadLine();

            var kontakt = new Kontakt(jmeno, prijmeni, telefonniCislo, email);
            Vloz(kontakt);

            Console.WriteLine($"Přidali jste nový kontakt: {kontakt.ToString()}");
        }

        public bool ExistujeKontakt(string telefonniCislo, string email)
        {
            foreach (var kontakt in db.Values)
            {
                if (kontakt.TelefonniCislo == telefonniCislo || kontakt.Mail == email)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
