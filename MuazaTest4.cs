using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazaTest
{
    [TestClass]
    public class MuazaTest4
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

            string googleSearch = Olx.Search("pik.ba");

            string olxMotocicleFilter = Olx.Filters();

            if (!googleSearch.Contains("ERROR") && (!olxMotocicleFilter.Contains("ERROR")))
            {
                subject = "Passed!" + subject;
                body = googleSearch + olxMotocicleFilter;
            }
            else
            {
                subject = "Failed! " + subject;
                body = googleSearch + olxMotocicleFilter;
            }

            Functions.SendEmailAttachment(subject,body);

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
