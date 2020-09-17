using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarteleKlinikeP.App_Code
{
    public class Manager
    {
        
        public static Dictionary<int, Person> persons = new Dictionary<int, Person>();
     
        public static Dictionary<int, Pacienti> pacientis = new Dictionary<int, Pacienti>();
        public static void Start()
        {
           

            pacientis.Add(1, new Pacienti()
            {
                Emri = "erjola",
                Mbiemri = "hasa",
                Identifikimi = 1234,
                PacientiId = 1,
                pacientiType=PacientiType.Operator
               
            });
            pacientis.Add(2, new Pacienti()
            {
                Emri = "qamile",
                Mbiemri = "hasa",
                Identifikimi = 4567,
                PacientiId = 2,
                pacientiType=PacientiType.User
                
            });
            persons.Add(2, new Person()
            {
                Emri = "Sidorela ",
                Mbiemri = "Seferi",
                Adressa = "Rruga Spitalit",
                Adressa2 = "Lagja nr2",
                KodiPacientit = "I Siguruar",
                Pavioni = "Pediatrik",
                Qyteti = "Librazhd",
                ID = 2,
              
            });
            persons.Add(1, new Person()
            {

                Emri = "Elona ",
                Mbiemri = "Hasa",
                Adressa = "Rruga Spitalit",
                Adressa2 = "Lagja nr2",
                KodiPacientit = "I Siguruar",
                Pavioni = "Pediatrik",
                Qyteti = "Librazhd",
                ID = 1,
            


            });
                
                
                
                
                


        }
    }


}
    
