
namespace CRM.Services
{
    public class GlobalService : Service, IGlobalService
    {

        private ClientService _clientService;
        private ProspectService _prospectService;

        public GlobalService()
        {
            _clientService = new ClientService();
            _prospectService = new ProspectService();
        }

        public int nombreClientsEtProspects()
        {

            return _clientService.nombreClients() + _prospectService.nombreProspects();
        }

    }
}
