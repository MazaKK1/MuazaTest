using Microsoft.VisualStudio.TestTools.UnitTesting;
using MuazaTest;
using System;

namespace MuazaTest
{
    [TestClass]
    public class MuazaTest2
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

            AcademyCourse.SignUp();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }

}