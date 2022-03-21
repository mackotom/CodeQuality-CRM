using CRM.Models;
using CRM.Stores;


namespace CRM.Services
{
    public static class ProspectService
    {

        public static Prospect ajoutProspect()
        {
            Adresse adresse = new Adresse("5 rue O nyme", "", "Grenoble", "38100", "France");
            Prospect prospect = new Prospect("Koko", "Prenom", "063770123", "prospect@example.com", "0002", adresse);

            AppStore.prospects.Add(prospect);

            return prospect;

        }


        public static void supprimerProspect(Prospect prospect)
        {
            AppStore.prospects.Remove(prospect);
        }


        public static void faireUneOffre(Prospect prospect)
        {
            Offre offre = new Offre("Viande Fraiche", 300, DateTime.Now.AddDays(7));

            prospect.offre = offre;

        } 


        public static Client? transformerEnClient(Prospect prospect)
        {

            long prospect_contact_secondes = ((DateTimeOffset)prospect.contact_time).ToUnixTimeSeconds();
            long temps_courant_secondes = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds();


            if (prospect_contact_secondes < temps_courant_secondes + 86400 && prospect.aEuUneOffre() && prospect.offre.accepte)
            {
                Client client = new Client(prospect.nom, prospect.prenom, prospect.mobile, prospect.mail, prospect.raison_social, prospect.adresse);
                
                supprimerProspect(prospect);
                
                ClientService.ajoutClient(client);

                return client;
            }

            return null;
        }


        public static Prospect first()
        {
            return AppStore.prospects.First();
        }

        public static int count() { 
            return AppStore.prospects.Count; 
        }


        public static bool accepterOffre(Prospect prospect)
        {

            if(prospect.offre != null)
            {
                prospect.offre.accepte = true;
                return true;
            }

            return false;

        }

    }
}
