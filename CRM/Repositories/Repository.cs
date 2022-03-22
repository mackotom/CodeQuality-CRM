using CRM.Stores;

namespace CRM.Repositories
{
    public abstract class Repository<T> : RepositoryInterface<T> where T : class
    {
        public void add(T model)
        {
            this.getStore().Add(model);
        }

        public void delete(T model)
        {
            this.getStore().Remove(model);
        }

        public List<T> getAll()
        {
            return this.getStore();
        }

        public T first()
        {
            return this.getStore().First();
        }

        public T? getByGuid(string guid)
        {
            // TO DO
            return null;
        }

        public int count()
        {
            return this.getStore().Count();
        }


        internal abstract List<T> getStore();


    }
}
