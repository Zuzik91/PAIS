using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_CORE.Model
{
    public class Doplnky
    {
        /*třída doplňků - pouhý výpis
        vzhledem k tomu, že neočekáváme větší rozšíření ze strany doplňků, je snadnější řešení pouze výpis
        nevýhoda - všude v kódu se v případě změny musí kód upravit
        */
        public int Id { get; set; }
        public bool WordAI { get; set; }
        public bool OutlookAI { get; set; }
        public bool IntegraceAI { get; set; }
        public bool Analyza { get; set; }
        public bool Anonymizace { get; set; }

        public Doplnky(int id, bool wordAI, bool outlookAI, bool integraceAI, bool analyza, bool anonymizace)
        {
            Id = id;
            WordAI = wordAI;
            OutlookAI = outlookAI;
            IntegraceAI = integraceAI;
            Analyza = analyza;
            Anonymizace = anonymizace;
        }
        public Doplnky(bool wordAI, bool outlookAI, bool integraceAI, bool analyza, bool anonymizace)
        {
            WordAI = wordAI;
            OutlookAI = outlookAI;
            IntegraceAI = integraceAI;
            Analyza = analyza;
            Anonymizace = anonymizace;
        }

        public override string ToString()
        {
            List<string> doplnky = new List<string>();
            if (WordAI) doplnky.Add("WordAI");
            if (OutlookAI) doplnky.Add("OutlookAI");
            if (IntegraceAI) doplnky.Add("IntegraceAI");
            if (Analyza) doplnky.Add("Analyza");
            if (Anonymizace) doplnky.Add("Anonymizace");
            return string.Join(", ", doplnky);
        }
    }
}
