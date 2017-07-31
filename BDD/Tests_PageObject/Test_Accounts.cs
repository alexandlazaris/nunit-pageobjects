using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BDD.Resources;
using BDD.Resources.PageObjects.npm;
using OpenQA.Selenium.Support.PageObjects;

namespace BDD.Tests_PageObject
{
    [TestClass]
    public class Test_Accounts
    {
        Homepage npmHome;

        [TestInitialize]
        public void Setup()
        {
            npmHome = new Homepage(ObjectSetup.Driver);
        }

        [TestMethod]
        public void AttemptLoginUnsuccessfully()
        {
            ObjectSetup.Driver.Navigate().GoToUrl("https://www.npmjs.com/");
            Account npmAccount = npmHome.SelectLogin();
            npmAccount.InputUsername("Hello world");
            npmAccount.InputPassword("Hello password");
            npmAccount.PressSubmit();
            Assert.IsTrue(npmAccount.IsErrorPresent());
        }
    }
}
