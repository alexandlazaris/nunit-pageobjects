﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using BDD.Resources.PageObjects;
using System;
using TechTalk.SpecFlow;
using System.Threading;

namespace BDD.SpecFlow_Steps.google
{
    [Binding]
    public sealed class StepDefinition
    {
        static RemoteWebDriver driver;
        private IWebElement element;
        private Homepage homepage = new Homepage(driver);
        private int genericWait = 2;

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

        [When(@"I enter in (.*) into locator ""(.*)""")]
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
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Cannot find: " + buttonOrLink + e.Message);
            }
            element = driver.FindElementByCssSelector(buttonOrLink);
            Console.WriteLine(element.Text);
            element.Click();
            ThenIWaitForSeconds(genericWait);
        }

        [When(@"I submit the form ""(.*)""")]
        public void WhenISubmitTheForm(string cssSelector)
        {
            //driver.FindElementByCssSelector(buttonOrLink).SendKeys(Keys.Enter)
            driver.FindElementByCssSelector(cssSelector).Submit();
        }

        [Then(@"I wait for ""(.*)"" seconds")]
        public void ThenIWaitForSeconds(int seconds)
        {
            seconds *= 1000;
            Thread.Sleep(seconds);
        }

        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}