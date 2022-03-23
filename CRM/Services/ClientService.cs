using CRM.Models;
using CRM.Repositories;

namespace CRM.Services
{
    public class ClientService : Service, IClientService
    {

        private readonly IRepository<Client> _clientRepository;

        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }

        public Client ajouterClient(string nom, string prenom, string mobile, string mail, string raison_social, Adresse adresse)
        {

            Client client = new Client(nom, prenom, mobile, mail, raison_social, adresse);

            _clientRepository.add(client);

            return client;

        }


        public void supprimerClient(Client client)
        {

            _clientRepository.delete(client);

        }


        public int nombreClients()
        {
            return _clientRepository.count();
        }



    }
}
