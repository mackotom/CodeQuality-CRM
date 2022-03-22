﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


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


            Adresse adresse = new Adresse("l1", "l2", "Grenoble", "38100", "France");
            ProspectService.ajouterProspect("Prospect1", "prop", "0090", "example.com", "002", adresse);

            afficherNombreClientsProspects();

            Prospect prospect = prospectRepository.first();

            ProspectService.transformerEnClient(prospect);

            afficherNombreClientsProspects();
            afficherNombreClients();
            afficherNombreProspects();

            ProspectService.faireUneOffre(prospect, "Viande Fraiche", 300, 5);
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
            Console.WriteLine("Nb Prospects: " + ProspectService.nombreProspects());
        }

        public static void afficherNombreClients()
        {
            Console.WriteLine("Nb Clients: " + ClientService.nombreClients());
        }

    }
}