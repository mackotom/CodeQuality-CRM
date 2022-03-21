using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    internal class Facture
    {
        public int id { get; set; }

        public decimal montant { get; set; }

        public DateTime date_emission { get; set; }

        public DateTime date_paiement { get; set; }

        public string etat { get; set; }

        public Offre offre { get; set; }


        public Facture (decimal montant, DateTime date_emission, DateTime date_paiement, string etat, Offre offre)
        {
            this.montant = montant;
            this.date_emission = date_emission;
            this.date_paiement = date_paiement;
            this.etat = etat;
            this.offre = offre;

        }


    }
}
