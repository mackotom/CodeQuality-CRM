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
            var client = ClientService.ajouterClient("nom1", "prenom1", "0637706126", "fake@example.com", "0001", this.CreerFausseAdresse());

            Assert.IsTrue(Stores.AppStore.Clients.Contains(client));

        }

        [TestMethod]
        public void TestSupprimerClient() {
        
            var client = ClientService.ajouterClient("n1", "p1", "m1", "m@example.com", "0001", this.CreerFausseAdresse());

            Assert.IsTrue(Stores.AppStore.Clients.Contains(client));

            ClientService.supprimerClient(client);

            Assert.IsTrue(!Stores.AppStore.Clients.Contains(client));
        
        }

        [TestMethod]
        public void TestNombreClients()
        {
            Assert.IsTrue(ClientService.nombreClients() == Stores.AppStore.Clients.Count);
        }


    }
}
