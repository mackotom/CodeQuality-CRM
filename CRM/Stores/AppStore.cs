using CRM.Models;
using CRM.Stores.Seeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Stores
{
    public static class AppStore
    {

        public static List<Client> clients = new List<Client>();


        public static List<Prospect> prospects = new List<Prospect>();



        public static void seed()
        {
            ProspectSeeder prospect_seeder = new ProspectSeeder();
            ClientSeeder client_seeder = new ClientSeeder();

            prospect_seeder.seed();
            client_seeder.seed();
        }

    }
}
