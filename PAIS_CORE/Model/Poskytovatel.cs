using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Model
{
    public class Poskytovatel
    {
        //třída Poskytovatel, obsahuje tyto vlastnosti:
        public int Id { get; set; }
        public TypPoskytovatele Typ { get; set; } // pomocí ENUM jsme vytvořili výběr ze 2 poskytivatelů
        //pomocí podmínky se bude určovat jaké vlastnosti daný Typ má
        public string ApiKeyPoskytovatele { get; set; }
        public string Url { get; set; }

        public Poskytovatel(int id, TypPoskytovatele typ, string apiKeyPoskytovatele, string url)
        {
            Id = id;
            Typ = typ;
            ApiKeyPoskytovatele = apiKeyPoskytovatele;
            Url = url;
        }
        public Poskytovatel(TypPoskytovatele typ, string apiKeyPoskytovatele, string url)
        {
            Typ = typ;
            ApiKeyPoskytovatele = apiKeyPoskytovatele;
            Url = url;
        }
    }

    public enum TypPoskytovatele
    {
        OpenAI, Azure
    }
}
