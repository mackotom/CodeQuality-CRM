using CRM.Models;
using CRM.Stores;

namespace CRM.Repositories
{
    public class ProspectRepository : Repository<Prospect>
    {

        internal override List<Prospect> getStore()
        {
            return AppStore.Prospects;
        }

    }
}
