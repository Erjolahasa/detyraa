using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarteleKlinikeP.Models
{
    public class Tedhena
    {
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Atesia { get; set; }
        public string Memesia { get; set; }
        public DateTime Datelindja { get; set; }
        public string VendLindja { get; set; }
        public string Vendbanimi { get; set; }
        public List<string> Kategoria { get; set; }
        public string GrupiGjakur { get; set; }
        public string Mjeku { get; set; }
        public string ReaksionNgaBarnat { get; set; }
        public string PersoniInteresuar { get; set; }
        public int Telefoni { get; set; }
    }
}