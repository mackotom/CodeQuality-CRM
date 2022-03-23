
namespace CRM.Models
{
    public interface IClient
    {
        List<Facture> factures { get; set; }
        bool recurrent { get; set; }

        bool toutesFacturesPayes();
    }
}