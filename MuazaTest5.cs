using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazaTest
{
    [TestClass]
    public class MuazaTest5
    {
        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);
        }
        [TestMethod]
        public void TestMethod()
        {

            string subject = "";
            string body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string googleMessage = phpTravels.Search("php Travels");

            string DemoMessage = phpTravels.Demo();

            string PricingMessage = phpTravels.Pricing();

            string FeaturesMessage = phpTravels.Features();

            string IntegrationsMessage = phpTravels.Integrations();

            string CompanyMessage = phpTravels.Company();

            string IntegrationsOptionsMessage = phpTravels.IntegrationsOptions();

            if (!googleMessage.Contains("ERROR") && (!DemoMessage.Contains("ERROR")) && (!PricingMessage.Contains("ERROR")) && (!FeaturesMessage.Contains("ERROR")) && (!IntegrationsMessage.Contains("ERROR")) && (!CompanyMessage.Contains("ERROR")) && (!IntegrationsOptionsMessage.Contains("ERROR")))
            {
                subject = "Passed!" + subject;
                body = googleMessage + DemoMessage + PricingMessage + FeaturesMessage + IntegrationsMessage + CompanyMessage;
            }
            else
            {
                subject = "Failed! " + subject;
                body = googleMessage + DemoMessage + PricingMessage + FeaturesMessage + IntegrationsMessage + CompanyMessage;
            }

            Functions.SendEmailAttachment(subject, body);

            Assert.IsTrue(subject.Contains("Passed"));
            Assert.IsFalse(subject.Contains("Failed"));
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }

}
