
namespace CRM.Services
{
    public class GlobalService : Service, IGlobalService
    {

        private readonly ClientService _clientService;
        private readonly ProspectService _prospectService;

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
