using PAIS_CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Database
{
    public class Doplnky_DB : IDb<Doplnky>
    {
        public static Dictionary<int, Doplnky> db = new Dictionary<int, Doplnky>();
        
        public static int posledniId = 1;

        public void Vloz(Doplnky doplnky)
        {
            db.Add(doplnky.Id, doplnky);
            doplnky.Id = posledniId++;
        }

        public void Smaz(Doplnky doplnky)
        {
            Smaz(doplnky.Id);
        }

        public void Smaz(int id)
        {
            db.Remove(id);
        }
        public void Aktualizuj(Doplnky doplnky)
        {
            int id = doplnky.Id;
            db[id] = (doplnky);
        }

        public Doplnky Ziskej(int id)
        {
            var doplnky = db[id];
            return doplnky;
        }

        public List<Doplnky> ZiskejVsechny()
        {
            List<Doplnky> vysledek = new List<Doplnky>();
            foreach(var doplnky in db)
            {
                vysledek.Add(doplnky.Value);
            }
            return vysledek;
        }
        public int PocetZaznamu()
        {
            return db.Count;
        }
    }
}
