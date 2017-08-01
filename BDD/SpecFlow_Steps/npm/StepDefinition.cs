using BDD.Resources;
using BDD.Resources.PageObjects.npm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.SpecFlow_Steps.npm
{
    [Binding]
    public sealed class StepDefinition
    {
        Homepage npmHome;
        SearchResults npmSearchResults;

        [When(@"I navigate to npm homepage")]
        public void WhenINavigateToNpmHomepage()
        {
            npmHome = new Homepage(ObjectSetup.Driver);
            npmSearchResults = new SearchResults(ObjectSetup.Driver);
            ObjectSetup.Driver.Navigate().GoToUrl("https://www.npmjs.com/");
        }

        [When(@"I click on all header links")]
        public void WhenIClickOnAllHeaderLinks()
        {
            
        }
    }
}
