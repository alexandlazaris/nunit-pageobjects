using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BDD.Resources;
using BDD.Resources.PageObjects.npm;
using OpenQA.Selenium.Support.PageObjects;

namespace BDD
{
    [TestClass]
    public class UnitTest1
    {
        Homepage npmHome;
        SearchResults npmSearchResults;

        [TestInitialize]
        public void Setup()
        {
            npmHome = new Homepage(ObjectSetup.Driver);
            PageFactory.InitElements(ObjectSetup.Driver, npmHome);
            npmSearchResults = new SearchResults(ObjectSetup.Driver);
            PageFactory.InitElements(ObjectSetup.Driver, npmSearchResults);
        }

        [TestMethod]
        public void TestMethod1()
        {
            
            ObjectSetup.Driver.Navigate().GoToUrl("https://www.npmjs.com/");
            npmHome.searchUsingInput("hello");
            npmSearchResults.printElements();
        }
    }
}
