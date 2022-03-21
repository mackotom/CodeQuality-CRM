namespace CRM.Models
{
    public abstract class Model
    {
        public string guid { get; }

        public Model()
        {
            guid = Guid.NewGuid().ToString();
        }
    }
}
