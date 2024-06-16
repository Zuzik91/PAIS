using PAIS_CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Database
{
    public class Uzivatel_DB: IDb<Uzivatel>
    {

        private static Dictionary<int, Uzivatel> db = new Dictionary<int, Uzivatel>();

        private static int posledniId = 1;

        //Vytvoří nového uživatele
        //Do slovníku s názvem db přidá uživatele
        //Dále definujeme uuživatelské ID jako poslední ID z důvodu unikátnosti ID (posledniId++)
        public void Vloz(Uzivatel uzivatel)
        {
            //zkontrolovat zda už uživatel neexistuje
            db.Add(posledniId, uzivatel);
            uzivatel.Id = posledniId;
            posledniId++;
        }

        //smaž uživatele dle jeho ID
        public void Smaz(Uzivatel uzivatel)
        {
            // podmínka if - pokud existuje id 
            Smaz(uzivatel.Id);
        }

        //smaže pouze konkrétní ID
        public void Smaz(int id)
        {
            // podmínka if - pokud existuje id 
            db.Remove(id);
        }

        //Upraví uživatele na základě jeho ID
        public void Aktualizuj(Uzivatel uzivatel)
        {
            int id = uzivatel.Id; //identifikátor, nebo-li klíč, podle kterého poté pracuje ve slovníku
            db[id] = uzivatel; //konkrétní záznam v db s klíčem id je nahrazen novým objektem uzivatel
        }

        //tato metoda vrací uživatele dle jeho id
        public Uzivatel Ziskej(int id)
        {
            //Pomocí klíče id se z db načte odpovídající objekt uživatele a uloží se do proměnné uzivatel
            var uzivatel = db[id];
            return uzivatel;
        }

        //tato metoda vrací nový seznam - list
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
