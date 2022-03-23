using CRM.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CRM.Tests.ServiceTests
{
    [TestClass]
    public class ProspectServiceTest : AppTest
    {
        [TestMethod]
        public void TestAjouterProspect()
        {
            var prospect = ProspectService.ajouterProspect("n1", "p1", "0", "m@example.com", "0001", this.CreerFausseAdresse());

            Assert.IsNotNull(prospect);

            Assert.IsTrue(Stores.AppStore.Prospects.Contains(prospect));
        }

        [TestMethod]
        public void TestSupprimerProspect()
        {

            var prospect = ProspectService.ajouterProspect("n1", "p1", "0", "m@example.com", "001", this.CreerFausseAdresse());

            Assert.IsTrue(Stores.AppStore.Prospects.Contains(prospect));

            ProspectService.supprimerProspect(prospect);

            Assert.IsTrue(!Stores.AppStore.Prospects.Contains(prospect));

        }

        [TestMethod]
        public void TestFaireUneOffre()
        {
            var prospect = this.CreerFauxProspect();

            Assert.IsNull(prospect.offre);

            ProspectService.faireUneOffre(prospect, "YOLOOFFER", 10, 3);

            Assert.IsNotNull(prospect.offre);

            DateTime now = DateTime.Now; 
            Assert.IsTrue(prospect.offre.nom == "YOLOOFFER");
            Assert.IsTrue(prospect.offre.montant == 10);
            Assert.IsTrue(prospect.offre.date_validite.Day == now.AddDays(3).Day);
        }

        [TestMethod]
        public void TestTransformerEnClient()
        {
            var prospect = this.CreerFauxProspect();


            ProspectService.faireUneOffre(prospect, "o", 10, 2);
            ProspectService.accepterOffre(prospect);
            var client = ProspectService.transformerEnClient(prospect);

            Assert.IsTrue(!Stores.AppStore.Prospects.Contains(prospect));

            if(client != null)
            {
                Assert.IsTrue(Stores.AppStore.Clients.Contains(client));
            }
            else
            {
                Assert.Fail();
            }


        }

        [TestMethod]
        public void TestTransformerEnClientEchecSiPasOffre() {

            var prospect = this.CreerFauxProspect();

            if(prospect.offre == null)
            {
                var client = ProspectService.transformerEnClient(prospect);

                Assert.IsNull(client);
                
            }
            else
            {
                Assert.Fail();
            }


        }

        [TestMethod]
        public void TestTransformerEnClientEchecSiPasAccepterOffre() {

            var prospect = this.CreerFauxProspect();

            ProspectService.faireUneOffre(prospect, "Offre", 100, 1);

            if(!prospect.aAccepteOffre())
            {
                var client = ProspectService.transformerEnClient(prospect);

                Assert.IsNull(client);
            }
            else
            {
                Assert.Fail();
            }


        }


        [TestMethod]
        public void TestAccepterOffre()
        {
            var prospect = this.CreerFauxProspect();

            ProspectService.faireUneOffre(prospect, "Offre", 100, 1);

            Assert.IsTrue(prospect.aEuUneOffre() && !prospect.aAccepteOffre());

            ProspectService.accepterOffre(prospect);

            Assert.IsTrue(prospect.aEuUneOffre() && prospect.aAccepteOffre());

        }

        [TestMethod]
        public void TestNombreProspects()
        {
            Stores.AppStore.clear();

            Assert.IsTrue(ProspectService.nombreProspects() == 0);

            ProspectService.ajouterProspect("n1", "p1", "0", "mail@example.com", "0989", this.CreerFausseAdresse());

            Assert.IsTrue(ProspectService.nombreProspects() == 1);

        }


    }
}
