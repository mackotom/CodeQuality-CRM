using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Repositories
{
    public interface RepositoryInterface<T> where T : class
    {

        List<T> getAll();

        T? getByGuid(string guid);

        void add(T model);

        void delete(T model);

        int count();
    }
}
