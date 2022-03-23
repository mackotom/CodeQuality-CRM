using CRM.Models.Enums;

namespace CRM.Models
{
    public class Facture : Model, IFacture
    {

        public decimal montant { get; set; }

        public DateTime date_emission { get; set; }

        public DateTime date_paiement { get; set; }

        public FactureEtat etat { get; set; }

        public Offre offre { get; set; }


        public Facture(decimal montant, DateTime date_emission, DateTime date_paiement, FactureEtat etat, Offre offre)
        {
            this.montant = montant;
            this.date_emission = date_emission;
            this.date_paiement = date_paiement;
            this.etat = etat;
            this.offre = offre;

        }





    }
}
