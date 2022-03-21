// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using CRM.Models;
using CRM.Services;

namespace CRM
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");


            ClientService.ajoutClient(null);

            ClientService.ajoutClient(null);

            ProspectService.ajoutProspect();

            afficherNombreClientsProspects();

            Prospect prospect = ProspectService.first();

            ProspectService.transformerEnClient(prospect);

            afficherNombreClientsProspects();
            afficherNombreClients();
            afficherNombreProspects();

            ProspectService.faireUneOffre(prospect);
            ProspectService.accepterOffre(prospect);
            ProspectService.transformerEnClient(prospect);

            afficherNombreClientsProspects();
            afficherNombreClients();
            afficherNombreProspects();

        }


        public static void afficherNombreClientsProspects()
        {
            Console.WriteLine("Nb Clients & Prospects: " + GlobalService.nombreClientsEtProspects());
        }


        public static void afficherNombreProspects()
        {
            Console.WriteLine("Nb Prospects: " + ProspectService.count());
        }

        public static void afficherNombreClients()
        {
            Console.WriteLine("Nb Clients: " + ClientService.count());
        }

    }
}