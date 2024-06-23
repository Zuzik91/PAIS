using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Model
{
    public class Kontakt
    {
        //bazání třída
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }

        public string TelefonniCislo;
        public string Mail { get; set; }
        public List<Pravo> Prava { get; set; } = new List<Pravo>();

        public Kontakt(int id, string jmeno, string prijmeni, string telefonniCislo, string mail)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelefonniCislo = telefonniCislo;
            Mail = mail;
        }

        public Kontakt(string jmeno, string prijmeni, string telefonniCislo, string mail)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelefonniCislo = telefonniCislo;
            Mail = mail;
        }

        public void NastavPravo(string nazevPrava, bool zapnute)
        {
            if (zapnute)
            {
                if (Prava.Any(q => q.Nazev == nazevPrava))
                {
                    Prava.First(q => q.Nazev == nazevPrava).MaPravo = true;
                }
                else
                {
                    Prava.Add(new Pravo() { Nazev = nazevPrava, MaPravo = true });
                }
            }
            else if (Prava.Any(q => q.Nazev == nazevPrava))
            {
                var odebranePravo = Prava.Find(q => q.Nazev == nazevPrava);
                Prava.Remove(odebranePravo);
            }
        }

        public bool ZjistiPravo(string nazevPrava)
        {
            var pravo = Prava.Find(m => m.Nazev == nazevPrava);
            var maPravo = pravo != null && pravo.MaPravo == true;
            if (maPravo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public class Pravo
        {
            public const string Prihlaseni = "Prihlaseni";
            public const string Admin = "Admin";

            public string Nazev { get; set; }
            public bool MaPravo { get; set; }
        }
        public override string ToString()
        {
            return $"{Id} - {Jmeno} {Prijmeni}: {TelefonniCislo}, {Mail}";
        }

        public string SpravnostTelefonnihoCisla
        {
            get => TelefonniCislo;
            set
            {
                if (!IsValidTelefonniCislo(value))
                    {
                    throw new ArgumentException("Telefonní číslo musí obsahovat pouze čísla a mít délku 9 až 15 čísel!");
                    }
                TelefonniCislo = value;
            }
        }

        private bool IsValidTelefonniCislo(string telefonniCislo)
        {
            if (string.IsNullOrWhiteSpace(telefonniCislo) || telefonniCislo.Length < 9 || telefonniCislo.Length > 15)
            {
                return false;
            }

            foreach (char t in telefonniCislo)
            {
                if (!char.IsDigit(t))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
