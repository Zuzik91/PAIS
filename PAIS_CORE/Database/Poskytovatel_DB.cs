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
            db.Add(poskytovatel.Id,poskytovatel);
            poskytovatel.Id = posledniId++;
        }

        public void Smaz(Poskytovatel poskytovatel)
        {
            Smaz(poskytovatel.Id);
        }

        public void Smaz(int id)
        {
            db.Remove(id);
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
