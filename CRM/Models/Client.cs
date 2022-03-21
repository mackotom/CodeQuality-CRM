using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    internal class Client : Contact
    {

        public int id { get; set; }

        public List<Facture> factures { get; set; }

        public bool recurrent { get; set; }

        public Client(string nom, string prenom, string mobile, string mail, string raison_social, Adresse adresse) : base(nom, prenom, mobile, mail, raison_social, adresse)
        {
            this.factures = new List<Facture>();
            this.recurrent = false;
        }



    }
}
