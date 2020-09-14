using KarteleKlinikeP;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.Entity;
namespace KarteleKlinikeP.Models
{
    public class Account
    {
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public int ID { get; set; }
        public string Adressa { get; set; }
        public string Adressa2 { get; set; }
        public string Qyteti { get; set; }
        public string Pavioni { get; set; }
        public string KodiPacientit { get; set; }
        

      
        }
    }
