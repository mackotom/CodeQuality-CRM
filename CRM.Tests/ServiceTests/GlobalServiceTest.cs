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

            Assert.IsTrue(getGlobalService().nombreClientsEtProspects() == 0);

            getProspectService().ajouterProspect("n1", "p1", "0", "mail@example.com", "0009", CreerFausseAdresse());

            getClientService().ajouterClient("n1", "p1", "0", "mail@example.com", "0001", CreerFausseAdresse());

            Assert.IsTrue(getGlobalService().nombreClientsEtProspects() == 2);
            
        }
    }
}