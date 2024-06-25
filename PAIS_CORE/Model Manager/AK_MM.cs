using PAIS_CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Database
{
    public class AK_MM : IMm<AK>
    {
        public static Dictionary<int, AK> db = new Dictionary<int, AK>();
        public static int posledniId = 1;

        public void Vloz(AK ak)
        {
            if (ak.Id != 0 && db.ContainsKey(ak.Id))
            {
                Console.WriteLine($"Advokátní kancelář {ak.NazevAk} již existuje");
            }
            else
            {
                ak.Id = posledniId++;
                db.Add(ak.Id, ak);
            }
        }

        public void Smaz(AK ak)
        {
            Smaz(ak.Id);
        }

        public void Smaz(int id)
        {
            if (db.ContainsKey(id))
            {
                db.Remove(id);
            }
            else
            {
                Console.WriteLine($"Advokátní kancelář s id {id} není v databázi.");
            }
        }

        public void Aktualizuj(AK ak)
        {
            int id = ak.Id;
            db[id] = (ak);
        }

        public AK Ziskej(int id)
        {
            var ak = db[id];
            return ak;
        }

        public List<AK> ZiskejVsechny()
        {
            List<AK> vysledek = new List<AK>();
            foreach (var ak in db)
            {
                vysledek.Add(ak.Value);
            }
            return vysledek;
        }

        public int PocetZaznamu()
        {
            return db.Count;
        }
        public bool ExistujeAk(string nazevAk)
        {
            foreach (var ak in db.Values)
            {
                if (ak.NazevAk == nazevAk)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
