
namespace CRM.Models
{
    public interface IProspect
    {
        List<Client> clients { get; set; }
        DateTime contact_time { get; set; }
        Offre? offre { get; set; }

        bool aAccepteOffre();
        bool aEuUneOffre();
    }
}