using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using BDD.Resources.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace BDD.Steps
{
    [Binding]
    public sealed class StepDefinition
    {
        static IWebDriver driver;
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
                driver = new EdgeDriver();
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

        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
