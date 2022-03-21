using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Services
{
    public static class GlobalService
    {

        public static int nombreClientsEtProspects()
        {
            return ClientService.count() + ProspectService.count();
        }

    }
}
