namespace CRM.Models
{
    public abstract class Model : IModel
    {
        public string guid { get; }

        protected Model()
        {
            guid = Guid.NewGuid().ToString();
        }
    }
}
