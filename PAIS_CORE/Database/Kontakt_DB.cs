using PAIS_CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Database
{
    public class Kontakt_DB : IDb<Kontakt>
    {
        private static Dictionary<int, Kontakt> db = new Dictionary<int, Kontakt>();

        private static int posledniId = 1;

        public void Vloz(Kontakt kontakt)
        {
            db.Add(kontakt.Id, kontakt);
            kontakt.Id = posledniId++;
        }

        public void Smaz(Kontakt kontakt)
        {
            Smaz(kontakt.Id);
        }

        public void Smaz(int id)
        {
            db.Remove(id);
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
    }
}
