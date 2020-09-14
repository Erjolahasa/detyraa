using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarteleKlinikeP.Models
{
    public enum PacientiType: byte
    {
        None = 0,
        Operator = 1,
        User = 2
    }
    public class Pacienti
    {
        public int PacientiId { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
       public int Identifikimi { get; set; }
        public PacientiType PacientiType { get; set; }

    }
    public class User : Pacienti
    {

    }
    public class Operator : Pacienti
    {

    }
}