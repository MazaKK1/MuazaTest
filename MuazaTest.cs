using Microsoft.VisualStudio.TestTools.UnitTesting;
using MuazaTest;
using System;

namespace MuazaTest
{
    [TestClass]
    public class MuazaTest
    {
        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);
        }
        [TestMethod]
        public void TestMethod1()
        {
            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            Academy387.FindQAAutomaionTest();

            Academy387.Contacts();

            Academy387.Clients();

            Academy387.Blog();

            Academy387.Events();

            Academy387.Lecturers();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }

}