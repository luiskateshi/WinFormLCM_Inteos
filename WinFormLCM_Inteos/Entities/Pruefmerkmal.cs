using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLCM_Inteos.Entities
{
    public class Pruefmerkmal
    {
        public int Id { get; set; }

        [DisplayName("Prüfmethode")]
        public string Pruefmethode { get; set; }

        [DisplayName("Verknüpfung")]
        public string Verknuepfung { get; set; }
        public string Anweisungen { get; set; }
    }
}
