using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    internal class Contact
    {
        public int id { get; set; }

        public string nom { get; set; }

        public string prenom { get; set; }

        public string mobile { get; set; }

        public string mail { get; set; }

        public string raison_social { get; set; }
        
        public Adresse adresse { get; set; }

        
        public Contact (string nom, string prenom, string mobile, string mail, string raison_social, Adresse adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mobile = mobile;
            this.mail = mail;
            this.raison_social = raison_social;
            this.adresse = adresse;
        }


    }
}
