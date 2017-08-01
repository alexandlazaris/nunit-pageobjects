using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BDD.Resources;
using BDD.Resources.PageObjects.npm;
using OpenQA.Selenium.Support.PageObjects;

namespace BDD
{
    [TestClass]
    public class Test_Smoke
    {
        Homepage npmHome;
        SearchResults npmSearchResults;

        [TestInitialize]
        public void Setup()
        {
            npmHome = new Homepage(ObjectSetup.Driver);
            npmSearchResults = new SearchResults(ObjectSetup.Driver);
        }

        [TestMethod]
        public void LinkThroughHeaderNavigation()
        {
            ObjectSetup.Driver.Navigate().GoToUrl("https://www.npmjs.com/");
            npmHome.ClickAllHeaderLinks();
        }

        [TestMethod]
        public void LinkThroughFooterNavigation()
        {
            ObjectSetup.Driver.Navigate().GoToUrl("https://www.npmjs.com/");
            npmHome.ClickFooterColumn01Links();
            npmHome.ClickFooterColumn02Links();
        }

        [TestMethod]
        public void SelectASearchResult()
        {
            ObjectSetup.Driver.Navigate().GoToUrl("https://www.npmjs.com/");
            npmHome.SearchUsingInput("hello");
            npmSearchResults.SelectAResultLink(8);
        }
    }
}
