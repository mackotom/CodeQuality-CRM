using CRM.Models;

namespace CRM.Stores.Seeders
{
    public class ProspectSeeder : SeederInterface
    {
        public void seed()
        {

            Adresse adresse = new Adresse("5 rue O nyme", "", "Grenoble", "38100", "France");
            Prospect prospect = new Prospect("Koko", "Prenom", "063770123", "prospect@example.com", "0002", adresse);

            AppStore.Prospects.Add(prospect);

            Prospect prospect_deux = new Prospect("Tabac", "Bar", "063770123", "prospect@example.com", "0003", adresse);
            AppStore.Prospects.Add(prospect_deux);

        }
    }
}
