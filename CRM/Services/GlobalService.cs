namespace CRM.Services
{
    public static class GlobalService
    {

        public static int nombreClientsEtProspects()
        {

            return ClientService.nombreClients() + ProspectService.nombreProspects();
        }

    }
}
