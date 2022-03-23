using CRM.Models.Enums;

namespace CRM.Models
{
    public class Client : Contact, IClient
    {

        public List<Facture> factures { get; set; }

        public bool recurrent { get; set; }

        public Client(string nom, string prenom, string mobile, string mail, string raison_social, Adresse adresse) : base(nom, prenom, mobile, mail, raison_social, adresse)
        {
            this.factures = new List<Facture>();
            this.recurrent = false;
        }


        public bool toutesFacturesPayes()
        {
            return this.factures.Any(facture => facture.etat != FactureEtat.PAYE);
        }


    }
}
