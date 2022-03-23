using CRM.Models;
using CRM.Services;

namespace CRM.Tests
{
    public class AppTest
    {



        protected static Adresse CreerFausseAdresse()
        {
            return new Adresse("l1", "l2", "Grenoble", "38100", "France");
        }


        protected static Prospect CreerFauxProspect()
        {
            return new Prospect("n1", "p1", "0909090909", "prospect@exple.com", "0001", CreerFausseAdresse());
        }

        protected static Client CreerFauxClient()
        {
            return new Client("n1", "p1", "08989898", "client@example.com", "0002", CreerFausseAdresse());
        }


        protected static ClientService getClientService()
        {
            return new ClientService();
        }


        protected static GlobalService getGlobalService()
        {
            return new GlobalService();
        }

        protected static ProspectService getProspectService()
        {
            return new ProspectService();
        }

    }
}
