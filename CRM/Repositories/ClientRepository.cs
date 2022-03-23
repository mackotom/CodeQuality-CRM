using CRM.Models;
using CRM.Stores;

namespace CRM.Repositories
{
    public class ClientRepository : Repository<Client>, IRepository<Client>
    {
        internal override List<Client> getStore()
        {
            return AppStore.Clients;
        }
    }
}
