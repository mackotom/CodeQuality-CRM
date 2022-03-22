using CRM.Models;
using CRM.Repositories;

namespace CRM.Services
{
    public static class ClientService
    {


        public static Client ajouterClient(string nom, string prenom, string mobile, string mail, string raison_social, Adresse adresse )
        {

            Client client = new Client(nom, prenom, mobile, mail, raison_social, adresse);

            ClientRepository clientRepository = new ClientRepository();

            clientRepository.add(client);

            return client;
        }


        public static void supprimerClient(Client client)
        {
            ClientRepository clientRepository = new ClientRepository();

            clientRepository.delete(client);
  
        }


        public static int nombreClients ()
        {
            ClientRepository clientRepository = new ClientRepository();

            return clientRepository.count();
        }



    }
}
