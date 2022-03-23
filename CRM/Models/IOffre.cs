
namespace CRM.Models
{
    public interface IOffre
    {
        bool accepte { get; set; }
        DateTime date_validite { get; set; }
        decimal montant { get; set; }
        string nom { get; set; }
    }
}