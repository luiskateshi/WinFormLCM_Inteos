using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLCM_Inteos.Entities
{
    public class LCMTyp
    {
        public int Id { get; set; }
        public string TypBeschreibung { get; set; }
        public string BemerkungIntern { get; set; }
        public int? PruefeinheitId { get; set; }
        public int? PruefmethodeId { get; set; }
    }

    public class LCMTypDTO
    {
        public int Id { get; set; }

        [DisplayName("Beschreibung")]
        public string TypBeschreibung { get; set; }

        [DisplayName("Bemerkung Intern")]
        public string BemerkungIntern { get; set; }

        [DisplayName("Prüfeinheit")]
        public string PruefeinheitName { get; set; }

        [DisplayName("Prüfmethode")]
        public string PruefmethodeName { get; set; }
    }
}
