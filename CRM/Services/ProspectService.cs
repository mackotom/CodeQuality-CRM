using CRM.Models;
using CRM.Repositories;
using CRM.Stores;


namespace CRM.Services
{
    public class ProspectService : Service, IProspectService
    {

        private readonly IRepository<Prospect> _prospectRepository;

        public ProspectService()
        {
            _prospectRepository = new ProspectRepository();
        }


        public Prospect ajouterProspect(string nom, string prenom, string mobile, string mail, string raison_social, Adresse adresse)
        {

            Prospect prospect = new Prospect(nom, prenom, mobile, mail, raison_social, adresse);

            _prospectRepository.add(prospect);

            return prospect;

        }


        public void supprimerProspect(Prospect prospect)
        {
            _prospectRepository.delete(prospect);
        }


        public void faireUneOffre(Prospect prospect, string nom, decimal montant, int jours)
        {
            Offre offre = new Offre(nom, montant, DateTime.Now.AddDays(jours));

            prospect.offre = offre;

        }


        public Client? transformerEnClient(Prospect prospect)
        {

            long prospect_contact_secondes = ((DateTimeOffset)prospect.contact_time).ToUnixTimeSeconds();
            long temps_courant_secondes = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds();


            if (prospect_contact_secondes < temps_courant_secondes + 86400 && prospect.aEuUneOffre() && prospect.aAccepteOffre())
            {

                var clientService = new ClientService();

                Client client = clientService.ajouterClient(
                    prospect.nom,
                    prospect.prenom,
                    prospect.mobile,
                    prospect.mail,
                    prospect.raison_social,
                    prospect.adresse
                );

                this.supprimerProspect(prospect);

                return client;
            }

            return null;
        }


        public bool accepterOffre(Prospect prospect)
        {

            if (prospect.offre != null)
            {
                prospect.offre.accepte = true;
                return true;
            }

            return false;

        }


        public int nombreProspects()
        {
            ProspectRepository prospectRepository = new ProspectRepository();

            return prospectRepository.count();
        }

    }
}
