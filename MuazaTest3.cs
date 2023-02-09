using Microsoft.VisualStudio.TestTools.UnitTesting;
using MuazaTest;
using OpenQA.Selenium.DevTools.V107.Fetch;
using System;
using System.Security.Cryptography.X509Certificates;

namespace MuazaTest
{
    [TestClass]
    public class MuazaTest3
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

            string pretragaMessage = radioSarajevo.Function1("Radio Sarajevo");

            if (pretragaMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prosao " + "\n" + pretragaMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = pretragaMessage;
            }

            string businessMessage = radioSarajevo.Function2("Biznis");

            if (businessMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prosao " + "\n" + businessMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = businessMessage;
            }

            string metromahalaMessage = radioSarajevo.Function3("Metromahala");

            if (metromahalaMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prosao " + "\n" + metromahalaMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = metromahalaMessage;
            }

            string magazinMessage = radioSarajevo.Function4("Magazin");

            if (magazinMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prosao " + "\n" + magazinMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = magazinMessage;
            }

            string sportMessage= radioSarajevo.Function5("Sport");

            if (sportMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prosao " + "\n" + sportMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = sportMessage;
            }

            string autoMotoMessage = radioSarajevo.Function6("Auto-Moto");

            if (autoMotoMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prosao " + "\n" + autoMotoMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = autoMotoMessage;
            }

            string multimediaMessage = radioSarajevo.Function7("Multimedia");

            if (multimediaMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prosao " + "\n" + multimediaMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = multimediaMessage;
            }

            string infoGrafMessage = radioSarajevo.Function8("InfoGrafike");

            if (infoGrafMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prosao " + "\n" + infoGrafMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = infoGrafMessage;
            }

            string radioMessage = radioSarajevo.Function9("Radio");

            if (radioMessage.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prosao " + "\n" + radioMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = radioMessage;
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }

}