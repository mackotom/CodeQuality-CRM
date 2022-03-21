using CRM.Models;
using CRM.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Services
{
    public static class ClientService
    {


        public static Client ajoutClient(Client? client_base)
        {

            Client? client = null;

            if(client_base == null)
            {
                Adresse adresse = new Adresse("5 rue O nyme", "", "Grenoble", "38100", "France");
                client = new Client("Doe", "Jhon", "0627706121", "mail@example.com", "0001", adresse);
            }
            else
            {
                client = client_base;
            }
            
            
            AppStore.clients.Add(client);

            return client;
        }


        public static void supprimerClient(Client client)
        {   
            AppStore.clients.Remove(client);
        }


        public static int count() { 
            return AppStore.clients.Count; 
        } 

    }
}
