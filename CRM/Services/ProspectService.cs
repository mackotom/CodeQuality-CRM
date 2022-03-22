using CRM.Models;
using CRM.Repositories;
using CRM.Stores;


namespace CRM.Services
{
    public static class ProspectService
    {

        public static Prospect ajouterProspect(string nom, string prenom, string mobile, string mail, string raison_social, Adresse adresse)
        {

            Prospect prospect = new Prospect(nom, prenom, mobile, mail, raison_social, adresse);
            
            ProspectRepository prospectRepository = new ProspectRepository();
            prospectRepository.add(prospect);
            
            return prospect;

        }


        public static void supprimerProspect(Prospect prospect)
        {
            ProspectRepository prospectRepository = new ProspectRepository();

            prospectRepository.delete(prospect);
        }


        public static void faireUneOffre(Prospect prospect, string nom, decimal montant, int jours)
        {
            Offre offre = new Offre(nom, montant, DateTime.Now.AddDays(jours));

            prospect.offre = offre;

        } 


        public static Client? transformerEnClient(Prospect prospect)
        {

            long prospect_contact_secondes = ((DateTimeOffset)prospect.contact_time).ToUnixTimeSeconds();
            long temps_courant_secondes = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds();


            if (prospect_contact_secondes < temps_courant_secondes + 86400 && prospect.aEuUneOffre() && prospect.aAccepteOffre())
            {

                Client client = ClientService.ajouterClient(
                    prospect.nom,
                    prospect.prenom,
                    prospect.mobile,
                    prospect.mail,
                    prospect.raison_social,
                    prospect.adresse
                );

                supprimerProspect(prospect);

                return client;
            }

            return null;
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


        public static int nombreProspects()
        {
            ProspectRepository prospectRepository = new ProspectRepository();

            return prospectRepository.count();
        }

    }
}
