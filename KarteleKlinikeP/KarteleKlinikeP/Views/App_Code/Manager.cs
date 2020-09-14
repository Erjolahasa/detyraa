using KarteleKlinikeP.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;


namespace KarteleKlinikeP
{
    public static class Manager
    {
        public static Dictionary<int, Account> Accounts = new Dictionary<int, Account>();
        public static Dictionary<int, Pacienti> pacientis = new Dictionary<int, Pacienti>();
        public static void Start()
        {
            Accounts.Add(1, new Account()
            {

            });

            pacientis.Add(1, new Pacienti()
            {
                Emri = "erjola",
                Mbiemri = "hasa",
                Identifikimi = 1234,
                PacientiId = 1,
                PacientiType = PacientiType.Operator
            });
            pacientis.Add(2, new Pacienti()
            {
                Emri = "qamile",
                Mbiemri = "hasa",
                Identifikimi = 4567,
                PacientiId = 2,
                PacientiType = PacientiType.User
            });


        }
    }


}
