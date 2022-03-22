using CRM.Models;
using CRM.Stores.Seeders;

namespace CRM.Stores
{
    public static class AppStore
    {

        private static readonly List<Client> clients = new List<Client>();

        public static List<Client> Clients
        {
            get { return clients; }
        }

        private static readonly List<Prospect> prospects = new List<Prospect>();

        public static List<Prospect> Prospects
        {
            get { return prospects; }
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
