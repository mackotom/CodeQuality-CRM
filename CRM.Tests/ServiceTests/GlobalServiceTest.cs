using CRM.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CRM.Tests.ServiceTests
{
    [TestClass]
    public class GlobalServiceTest : AppTest
    {
        [TestMethod]
        public void TestNombreClientsEtProspects() 
        {

            Stores.AppStore.clear();

            Assert.IsTrue(GlobalService.nombreClientsEtProspects() == 0);

            ProspectService.ajouterProspect("n1", "p1", "0", "mail@example.com", "0009", this.CreerFausseAdresse());

            ClientService.ajouterClient("n1", "p1", "0", "mail@example.com", "0001", this.CreerFausseAdresse());

            Assert.IsTrue(GlobalService.nombreClientsEtProspects() == 2);
            
        }
    }
}