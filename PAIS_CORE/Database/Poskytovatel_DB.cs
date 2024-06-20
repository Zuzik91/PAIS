using PAIS_CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Database
{
    public class Poskytovatel_DB : IDb<Poskytovatel>
    {
        private static Dictionary<int, Poskytovatel> db = new Dictionary<int, Poskytovatel>();

        private static int posledniId = 1;

        public void Vloz(Poskytovatel poskytovatel)
        {
            if (poskytovatel.Id != 0 && db.ContainsKey(poskytovatel.Id))
            {
                Console.WriteLine($"Poskytovatel {poskytovatel.Typ} již existuje");
            }
            else
            {
                poskytovatel.Id = posledniId++;
                db.Add(poskytovatel.Id, poskytovatel);
            }
        }

        public void Smaz(Poskytovatel poskytovatel)
        {
            Smaz(poskytovatel.Id);
        }

        public void Smaz(int id)
        {
            if (db.ContainsKey(id))
            {
                Console.WriteLine($"Poskytovatel s id {id} není v databázi.");
            }
            else
            {
                db.Remove(id);
            }
        }
        public void Aktualizuj(Poskytovatel poskytovatel)
        {
            int id = poskytovatel.Id;
            db[id] = (poskytovatel);
        }

        public Poskytovatel Ziskej(int id)
        {
            var poskytovatel = db[id];
            return poskytovatel;
        }

        public List<Poskytovatel> ZiskejVsechny()
        {
            List<Poskytovatel> vysledek = new List<Poskytovatel>();
            foreach(var poskytovatel in db)
            {
                vysledek.Add(poskytovatel.Value);
            }
            return vysledek;
        }

        public int PocetZaznamu()
        {
            return db.Count;
        }
    }
}
