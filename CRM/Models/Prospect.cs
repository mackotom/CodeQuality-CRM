using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Prospect : Contact
    {

        public DateTime contact_time { get; set; }

        public List<Client> clients { get; set; }

        public Offre? offre { get; set; }

        public Prospect(string nom, string prenom, string mobile, string mail, string raison_social, Adresse adresse) : 
            base(nom, prenom, mobile, mail, raison_social, adresse)
        {
            this.contact_time = DateTime.Now;
            this.clients = new List<Client>();
            this.offre = null;
        }


        public bool aEuUneOffre()
        {
            return this.offre != null;
        }


        public bool aAccepteOffre()
        {
            return this.offre != null && this.offre.accepte;
        }


    }
}
