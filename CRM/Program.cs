using CRM.Models;
using CRM.Repositories;
using CRM.Services;

namespace CRM
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");

            // Seeder
            Stores.AppStore.seed();

            
            ProspectRepository prospectRepository = new ProspectRepository();
            ProspectService prospectService = new ProspectService();

            Adresse adresse = new Adresse("l1", "l2", "Grenoble", "38100", "France");
            prospectService.ajouterProspect("Prospect1", "prop", "0090", "example.com", "002", adresse);

            afficherNombreClientsProspects();

            Prospect prospect = prospectRepository.first();

            prospectService.transformerEnClient(prospect);

            afficherNombreClientsProspects();
            afficherNombreClients();
            afficherNombreProspects();

            prospectService.faireUneOffre(prospect, "Viande Fraiche", 300, 5);
            prospectService.accepterOffre(prospect);
            prospectService.transformerEnClient(prospect);

            afficherNombreClientsProspects();
            afficherNombreClients();
            afficherNombreProspects();

            ClientRepository clientRepository = new ClientRepository();
            Client client = clientRepository.first();

            afficherClientPayeToutesSesFactures(client);

        }


        public static void afficherNombreClientsProspects()
        {
            Console.WriteLine("Nb Clients & Prospects: " + getGlobalService().nombreClientsEtProspects());
        }


        public static void afficherNombreProspects()
        {
            Console.WriteLine("Nb Prospects: " + getProspectService().nombreProspects());
        }

        public static void afficherNombreClients()
        {
            Console.WriteLine("Nb Clients: " + getClientService().nombreClients());
        }


        public static void afficherClientPayeToutesSesFactures(Client client)
        {

            string statut = client.toutesFacturesPayes() ? "oui" : "non";
            Console.WriteLine("Client: " + client.guid + " a payé toutes ses factures : " + statut);
        }


        public static ClientService getClientService()
        {
            return new ClientService();
        }

        public static ProspectService getProspectService()
        {
            return new ProspectService();
        }


        public static GlobalService getGlobalService()
        {
            return new GlobalService();
        }

    }
}