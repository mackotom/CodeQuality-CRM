using CRM.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRM.Tests.ServiceTests
{
    [TestClass]
    public class ClientServiceTest : AppTest
    {

        [TestMethod]
        public void TestAjouterClient()
        {
            var client = getClientService().ajouterClient("nom1", "prenom1", "0637706126", "fake@example.com", "0001", CreerFausseAdresse());

            Assert.IsTrue(Stores.AppStore.Clients.Contains(client));

        }

        [TestMethod]
        public void TestSupprimerClient() {
        
            var client = getClientService().ajouterClient("n1", "p1", "m1", "m@example.com", "0001", CreerFausseAdresse());

            Assert.IsTrue(Stores.AppStore.Clients.Contains(client));

            getClientService().supprimerClient(client);

            Assert.IsTrue(!Stores.AppStore.Clients.Contains(client));
        
        }

        [TestMethod]
        public void TestNombreClients()
        {
            Assert.IsTrue(getClientService().nombreClients() == Stores.AppStore.Clients.Count);
        }


    }
}
