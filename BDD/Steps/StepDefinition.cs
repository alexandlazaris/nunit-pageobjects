using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using BDD.Resources.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Threading;

namespace BDD.Steps
{
    [Binding]
    public sealed class StepDefinition
    {
        //static IWebDriver driver;
        static RemoteWebDriver driver;
        IWebElement element;
        Homepage homepage = new Homepage(driver);

        [Given(@"I open (.*)")]
        public void GivenIOpen(string browser)
        {
            if (browser.Equals("Chrome"))
                driver = new ChromeDriver();
            if (browser.Equals("Firefox"))
                driver = new FirefoxDriver();
            if (browser.Equals("IE11"))
                driver = new InternetExplorerDriver();
            if (browser.Equals("Edge"))
                driver = new EdgeDriver(@"C:\bin");
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [Then(@"I have successfully loaded the homepage")]
        public void ThenIHaveSuccessfullyLoadedTheHomepage()
        {
            element = driver.FindElement(By.CssSelector("div#hplogo"));
            Assert.IsTrue(element.Enabled);
        }

        [When(@"I enter in ""(.*)"" into locator ""(.*)""")]
        public void WhenIEnterInIntoLocator(string text, string cssSelector)
        {
            driver.FindElementByCssSelector(cssSelector).SendKeys(text);
        }

        [When(@"I press this ""(.*)""")]
        public void WhenIPressThis(string buttonOrLink)
        {
            try
            {
                Assert.IsTrue(driver.FindElementByCssSelector(buttonOrLink).Enabled);
                element = driver.FindElementByCssSelector(buttonOrLink);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Cannot find: " + buttonOrLink + e.Message);
            }
            element.Click();
            //need to add a wait before clicking
        }

        [When(@"I submit this form ""(.*)""")]
        public void WhenISubmitThisForm(string form)
        {
            driver.FindElementByCssSelector(form).Submit();
        }

        [Then(@"I wait for ""(.*)"" seconds")]
        public void ThenIWaitForSeconds(int milliSeconds)
        {//allow user to enter in seconds, do maths to make it milli seconds
            Thread.Sleep(milliSeconds);
        }

        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
