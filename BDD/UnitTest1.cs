using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BDD.Resources;

namespace BDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ObjectSetup.Driver.Navigate().GoToUrl("http://www.google.com");
        }
    }
}
