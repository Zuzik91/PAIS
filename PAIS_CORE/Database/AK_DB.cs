using PAIS_CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Database
{
    public class AK_DB : IDb<AK>
    {
        //databáze Poskytovatele
        public static Dictionary<int, AK> db = new Dictionary<int, AK>();
        public static int posledniId = 1;

        public void Vloz(AK ak)
        {
            db.Add(ak.Id,ak);
            ak.Id = posledniId++;
        }

        public void Smaz(AK ak)
        {
            Smaz(ak.Id);
        }

        public void Smaz(int id)
        {
            db.Remove(id);
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
    }
}
