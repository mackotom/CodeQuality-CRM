using CRM.Models;
using CRM.Stores;

namespace CRM.Repositories
{
    public class ClientRepository : Repository<Client>
    {
        internal override List<Client> getStore()
        {
            return AppStore.Clients;
        }
    }
}
