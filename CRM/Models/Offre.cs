using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Offre : Model, IOffre
    {

        public string nom { get; set; }

        public decimal montant { get; set; }

        public DateTime date_validite { get; set; }

        public bool accepte { get; set; }

        public Offre(string nom, decimal montant, DateTime date_validite)
        {
            this.nom = nom;
            this.montant = montant;
            this.date_validite = date_validite;
            this.accepte = false;
        }

    }
}
