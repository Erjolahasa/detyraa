using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarteleKlinikeP.Models
{
    public class Shtrimi
    {
        public DateTime Data { get; set; }
        public List<string> kategoria { get; set; }
        public string Mjeku { get; set; }
        public List<string> Transferuar { get; set; }
        public string DiagnozaeDergimit { get; set; }
        public string DiagnozaeShtrimit { get; set; }
        public string MjekuShtrimit { get; set; }
        public string DiagnozaKlinike { get; set; }
        public string SemundjeTeTjera { get; set; }
        public string DiagnozaPerfundimatre { get; set; }
        public DateTime DataEDaljes { get; set; }
        public List<string> GjendjaePacientit { get; set; }
    }
}