using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarteleKlinikeP.Models
{
    public class Anamneza
    {
        public string Ankesat { get; set; }
        public string HistorikuSemundjeve { get; set; }
        public string MjekimetePerdorura { get; set; }
        public string SemundjeteKaluara { get; set; }
        public string AnamnezaFamiljare { get; set; }
        public string EkzaminimiObjektivSipasOrganve { get; set; }
    }
}