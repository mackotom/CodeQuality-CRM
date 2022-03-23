using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Repositories
{
    public interface IRepository<T> where T : class
    {

        List<T> getAll();

        T? getByGuid(string guid);

        void add(T model);

        void delete(T model);

        int count();

    }
}
