using CRM.Models;

namespace CRM.Stores.Seeders
{
    public class ClientSeeder : ISeeder
    {


        public void seed()
        {

            Adresse adresse = new Adresse("5 rue O nyme", "", "Grenoble", "38100", "France");
            Client client = new Client("Jhon", "Doe", "063770123", "client@example.com", "0001", adresse);

            AppStore.Clients.Add(client);


        }


    }
}
