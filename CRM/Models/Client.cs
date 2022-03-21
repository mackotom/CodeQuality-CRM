using CRM.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Client : Contact
    {

        public List<Facture> factures { get; set; }

        public bool recurrent { get; set; }

        public Client(string nom, string prenom, string mobile, string mail, string raison_social, Adresse adresse) : base(nom, prenom, mobile, mail, raison_social, adresse)
        {
            this.factures = new List<Facture>();
            this.recurrent = false;
        }


        bool toutesFacturesPayes()
        {
            return this.factures.Where(facture => facture.etat != FactureEtat.PAYE).Count() <= 0;
        }


    }
}
