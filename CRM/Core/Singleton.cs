namespace CRM.Core
{
    public class Singleton
    {

        private static Singleton _instance;
        static readonly object instanceLock = new object();

        private Singleton() { }

        public static Singleton Instance {

            get
            {
                lock (instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
                return _instance;
            }
        
        }



    }
}
