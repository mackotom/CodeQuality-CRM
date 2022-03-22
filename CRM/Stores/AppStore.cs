using CRM.Models;
using CRM.Stores.Seeders;

namespace CRM.Stores
{
    public static class AppStore
    {

        public static List<Client>? clients;

        public static List<Prospect>? prospects;

        public static void init()
        {
            clients = new List<Client>();
            prospects = new List<Prospect>();
        }

        public static void seed()
        {
            ProspectSeeder prospect_seeder = new ProspectSeeder();
            ClientSeeder client_seeder = new ClientSeeder();
            prospect_seeder.seed();
            client_seeder.seed();
        }

    }
}
