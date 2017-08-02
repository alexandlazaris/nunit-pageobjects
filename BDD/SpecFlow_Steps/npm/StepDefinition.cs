using BDD.Resources;
using BDD.Resources.PageObjects.npm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace BDD.SpecFlow_Steps.npm
{
    //TODO add partial class for getting TestContext!!!
    [Binding]
    public sealed class StepDefinition
    {
        Homepage npmHome;
        SearchResults npmSearchResults;
        Account npmAccount;

        [BeforeScenario]
        public void Setup()
        {
            Control.InitSpecflow();
            Console.WriteLine("\nThis is before the scenario");
            npmHome = new Homepage(ObjectSetup.Driver);
            npmSearchResults = new SearchResults(ObjectSetup.Driver);
        }

        [AfterScenario]
        public void Finish()
        {
            Control.Finish();
        }

        [Given(@"I navigate to npm homepage")]
        public void GivenINavigateToNpmHomepage()
        {
            ObjectSetup.Driver.Navigate().GoToUrl("https://www.npmjs.com/");
        }

        [When(@"I click on all header links")]
        public void WhenIClickOnAllHeaderLinks()
        {
            npmHome.ClickAllHeaderLinks();
        }

        [Then(@"I will finish on the ""(.*)"" page")]
        public void ThenIWillFinishOnThe(string page)
        {
            if (page.Equals("support page"))
                Assert.IsTrue(ObjectSetup.Driver.Url.Equals("https://www.npmjs.com/support"));
            if (page.Equals("home page"))
                Assert.IsTrue(ObjectSetup.Driver.Url.Equals("https://www.npmjs.com/"));
            if (page.Equals("chatbot"))
                Assert.IsTrue(ObjectSetup.Driver.Url.Equals("https://www.npmjs.com/packages/chatbot"));
        }

        [When(@"I click on all footer links")]
        public void WhenIClickOnAllFooterLinks()
        {
            npmHome.ClickFooterColumn01Links();
            npmHome.ClickFooterColumn02Links();
        }

        [When(@"I search for a ""(.*)"" package")]
        public void WhenISearchForAPackage(string search)
        {
            npmHome.SearchUsingInput(search);
            npmSearchResults.SelectAResultLink(1);
        }

        [When(@"I search for a ""(.*)"" package and I select number (.*)")]
        public void WhenISearchForAPackageAndISelectNumber(string search, int number)
        {
            npmHome.SearchUsingInput(search);
            npmSearchResults.SelectAResultLink(number);
        }

        [When(@"I press ""(.*)""")]
        public void WhenIPress(string button)
        {
            if (button.Equals("login"))
                npmAccount = npmHome.SelectLogin();
            if (button.Equals("submit"))
                npmAccount.SelectSubmit();
            if (button.Equals("sign up"))
                npmAccount.SelectSignUp();
        }

        [When(@"I input ""(.*)"" into ""(.*)""")]
        public void WhenIInput(string text, string field)
        {
            if (field.Equals("fullname"))
                npmAccount.InputFullname(text);
            if (field.Equals("username"))
                npmAccount.InputUsername(text);
            if (field.Equals("password"))
                npmAccount.InputPassword(text);
            if (field.Equals("email"))
                npmAccount.InputEmail(text);
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(npmAccount.IsErrorPresent());
        }

        [When(@"I accept terms and conditions")]
        public void WhenIAcceptTermsAndConditions()
        {
            npmAccount.AgreeTermsAndConditions();
        }

        [Then(@"the submit button should be selectable")]
        public void ThenTheSubmitButtonShouldBeSelectable()
        {
            string buttonState = npmAccount._btnSubmit.GetCssValue("disabled");
            Console.WriteLine("button has : " + buttonState);
        }
    }
}
