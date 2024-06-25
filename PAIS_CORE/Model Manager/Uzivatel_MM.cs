using PAIS_CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Database
{
    public class Uzivatel_MM : IMm<Uzivatel>
    {

        private static Dictionary<int, Uzivatel> db = new Dictionary<int, Uzivatel>();

        private static int posledniId = 1;

        /// <summary>
        /// Vytvoří nového uživatele
        /// Do slovníku s názvem db přidá uživatele
        /// Dále definujeme uživatelské ID jako poslední ID z důvodu unikátnosti ID (posledniId++)
        /// </summary>
        /// <param name="uzivatel"></param>
        public void Vloz(Uzivatel uzivatel)
        {
            if (uzivatel.Id != 0 && db.ContainsKey(uzivatel.Id))
            {
                Console.WriteLine($"Uživatel {uzivatel.Jmeno} {uzivatel.Prijmeni} již existuje");
            }
            else
            {
                uzivatel.Id = posledniId++;
                db.Add(uzivatel.Id, uzivatel);
            }
        }

        public void Smaz(Uzivatel uzivatel)
        {
            Smaz(uzivatel.Id);
        }

        public void Smaz(int id)
        {
            if (db.ContainsKey(id))
            {
                db.Remove(id);
            }
            else
            {
                Console.WriteLine($"Uživatel s id {id} není v databázi.");
            }
        }

        /// <summary>
        /// Upraví uživatele na základě jeho ID
        /// </summary>
        /// <param name="uzivatel"></param>
        public void Aktualizuj(Uzivatel uzivatel)
        {
            int id = uzivatel.Id; //identifikátor, nebo-li klíč, podle kterého poté pracuje ve slovníku
            db[id] = uzivatel; //konkrétní záznam v db s klíčem id je nahrazen novým objektem uzivatel
        }

        /// <summary>
        /// Metoda vrací uživatele dle jeho id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Uzivatel Ziskej(int id)
        {
            //Pomocí klíče id se z db načte odpovídající objekt uživatele a uloží se do proměnné uzivatel
            var uzivatel = db[id];
            return uzivatel;
        }

        /// <summary>
        /// Metoda vrací nový seznam - list
        /// </summary>
        /// <returns></returns>
        public List<Uzivatel> ZiskejVsechny()
        {
            List<Uzivatel> vysledek = new List<Uzivatel>();

            foreach (var uzivatel in db)
            {
                var abc = uzivatel.Value;
                vysledek.Add(abc);
            }

            return vysledek;
        }

        public int PocetZaznamu()
        {
            var abc = db.Count;
            return abc;
        }
    }
}
