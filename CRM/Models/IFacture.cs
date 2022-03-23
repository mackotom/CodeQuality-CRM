using CRM.Models.Enums;

namespace CRM.Models
{
    public interface IFacture
    {
        DateTime date_emission { get; set; }
        DateTime date_paiement { get; set; }
        FactureEtat etat { get; set; }
        decimal montant { get; set; }
        Offre offre { get; set; }
    }
}