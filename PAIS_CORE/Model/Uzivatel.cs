using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Model
{
    public class Uzivatel : Kontakt
    {
        //třída Uživatel, dědí z bazální třídy Kontakt
        //navíc má vlastnost ApiTokenUzivatele
        public string ApiTokenUzivatele { get; set; }

        public Uzivatel(int id, string jmeno, string prijmeni, int telefonniCislo, string mail, string apiTokenUzivatele) : base(id, jmeno, prijmeni, telefonniCislo, mail)
        {
            ApiTokenUzivatele = apiTokenUzivatele;
        }

        public Uzivatel(string jmeno, string prijmeni, int telefonniCislo, string mail, string apiTokenUzivatele) : base(jmeno, prijmeni, telefonniCislo, mail)
        {
            ApiTokenUzivatele = apiTokenUzivatele;
        }

        public override string ToString()
        {
            return $"{Id} - {Jmeno} {Prijmeni}: {TelefonniCislo}, {Mail} - {ApiTokenUzivatele}";
        }
    }
}
