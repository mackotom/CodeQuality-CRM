using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    internal class Offre
    {
        public int id { get; set; }

        public string nom { get; set; }

        public decimal montant { get; set; }

        public DateTime date_validite { get; set; }

        public Offre(string nom, decimal montant, DateTime date_validite)
        {
            this.nom = nom;
            this.montant = montant;
            this.date_validite = date_validite;
        }

    }
}
