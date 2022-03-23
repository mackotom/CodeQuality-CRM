using CRM.Models;

namespace CRM.Services
{
    public interface IClientService
    {
        Client ajouterClient(string nom, string prenom, string mobile, string mail, string raison_social, Adresse adresse);
        int nombreClients();
        void supprimerClient(Client client);
    }
}