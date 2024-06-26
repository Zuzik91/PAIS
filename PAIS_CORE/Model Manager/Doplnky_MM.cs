﻿using PAIS_CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Database
{
    public class Doplnky_MM : IMm<Doplnky>
    {
        private static Dictionary<int, Doplnky> db = new Dictionary<int, Doplnky>();
        
        private static int posledniId = 1;

        public void Vloz(Doplnky doplnky)
        {
            if (doplnky.Id != 0 && db.ContainsKey(doplnky.Id))
            {
                Console.WriteLine("Doplněk již existuje");
            }
            else
            {
                doplnky.Id = posledniId++;
                db.Add(doplnky.Id, doplnky);
            }
        }

        public void Smaz(Doplnky doplnky)
        {
            Smaz(doplnky.Id);
        }

        public void Smaz(int id)
        {
            if (db.ContainsKey(id))
            {
                db.Remove(id);
            }
            else
            {
                Console.WriteLine($"Doplněk s id {id} není v databázi.");
            }
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
