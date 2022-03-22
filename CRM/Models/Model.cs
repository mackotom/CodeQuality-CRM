namespace CRM.Models
{
    public abstract class Model
    {
        public string guid { get; }

        protected Model()
        {
            guid = Guid.NewGuid().ToString();
        }
    }
}
