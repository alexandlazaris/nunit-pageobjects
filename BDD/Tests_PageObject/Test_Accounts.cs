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
            Control.InitSpecflow();
            npmHome = new Homepage(ObjectSetup.Driver);
        }

        [TestMethod]
        public void AttemptLoginUnsuccessfully()
        {
            ObjectSetup.Driver.Navigate().GoToUrl("https://www.npmjs.com/");
            Account npmAccount = npmHome.SelectLogin();
            npmAccount.InputUsername("Hello world");
            npmAccount.InputPassword("Hello password");
            npmAccount.SelectSubmit();
            Assert.IsTrue(npmAccount.IsErrorPresent());
        }

        [TestMethod]
        public void AttemptLoginUnsuccessfullyAndSignUp()
        {
            ObjectSetup.Driver.Navigate().GoToUrl("https://www.npmjs.com/");
            Account npmAccount = npmHome.SelectLogin();
            npmAccount.InputUsername("Hello world");
            npmAccount.InputPassword("Hello password");
            npmAccount.SelectSubmit();
            npmAccount.SelectSignUp();
            npmAccount.InputFullname("Hello fullname");
            npmAccount.InputUsername("Hello username");
            npmAccount.InputEmail("Hello@email.com");
            npmAccount.InputPassword("Hello password");
            npmAccount.AgreeTermsAndConditions();
        }
    }
}
