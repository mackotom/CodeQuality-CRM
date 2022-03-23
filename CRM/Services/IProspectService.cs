using CRM.Models;

namespace CRM.Services
{
    public interface IProspectService
    {
        bool accepterOffre(Prospect prospect);
        Prospect ajouterProspect(string nom, string prenom, string mobile, string mail, string raison_social, Adresse adresse);
        void faireUneOffre(Prospect prospect, string nom, decimal montant, int jours);
        int nombreProspects();
        void supprimerProspect(Prospect prospect);
        Client? transformerEnClient(Prospect prospect);
    }
}