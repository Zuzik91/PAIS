using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Model
{
    public class AK
    {
        //nová třída AK
        public int Id { get; set; }
        public string NazevAk { get; set; }
        /// <summary>
        /// Obsahuje kontaktní osobu, kterou bere ze třídy kontakt
        /// </summary>
        public Kontakt KontaktniOsoba { get; set; }

        public List<Uzivatel> Uzivatele { get; set; } = new List<Uzivatel>(); //obsahuje list typu uživatel s názvem Uživatele

        public List<Poskytovatel> Poskytovatele { get; set; } = new List<Poskytovatel>(); //obsahuje list typu poskytovatel s názvem Poskytovatelé

        public Doplnky Doplnky { get; set; } //obsahuje Doplňky, které bere ze třídy Doplnky

        public string GooglovskaTabulka { get; set; } //odkaz

        public string PraetorAiService { get; set; } //odkaz

        public string NazevServeru { get; set; }

        public AK(int id, string nazevAk, Kontakt kontaktniOsoba, List<Uzivatel> uzivatele, List<Poskytovatel> poskytovatele, Doplnky doplnky, string googlovskaTabulka, string praetorAiService, string nazevServeru)
        {
            Id = id;
            NazevAk = nazevAk;
            KontaktniOsoba = kontaktniOsoba;
            Uzivatele = uzivatele;
            Poskytovatele = poskytovatele;
            Doplnky = doplnky;
            GooglovskaTabulka = googlovskaTabulka;
            PraetorAiService = praetorAiService;
            NazevServeru = nazevServeru;
        }
        public AK(string nazevAk, Kontakt kontaktniOsoba, List<Uzivatel> uzivatele, List<Poskytovatel> poskytovatele, Doplnky doplnky, string googlovskaTabulka, string praetorAiService, string nazevServeru)
        {
            NazevAk = nazevAk;
            KontaktniOsoba = kontaktniOsoba;
            Uzivatele = uzivatele;
            Poskytovatele = poskytovatele;
            Doplnky = doplnky;
            GooglovskaTabulka = googlovskaTabulka;
            PraetorAiService = praetorAiService;
            NazevServeru = nazevServeru;
        }
    }
    
}
