using CRM.Models;
using CRM.Services;

namespace CRM.Tests
{
    public class AppTest
    {



        protected Adresse CreerFausseAdresse()
        {
            return new Adresse("l1", "l2", "Grenoble", "38100", "France");
        }


        protected Prospect CreerFauxProspect()
        {
            return new Prospect("n1", "p1", "0909090909", "prospect@exple.com", "0001", this.CreerFausseAdresse());
        }

        protected Client CreerFauxClient()
        {
            return new Client("n1", "p1", "08989898", "client@example.com", "0002", this.CreerFausseAdresse());
        }


        protected ClientService getClientService()
        {
            return new ClientService();
        }


        protected GlobalService getGlobalService()
        {
            return new GlobalService();
        }

        protected ProspectService getProspectService()
        {
            return new ProspectService();
        }

    }
}
