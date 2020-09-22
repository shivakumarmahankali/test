using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int value = 2;

            Assert.AreEqual(value-1,1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string data = "TFS CI/CD Run";

            Assert.AreEqual("TFS CI/CD Run1", data);
        }
    }
}
