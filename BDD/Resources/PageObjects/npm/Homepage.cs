using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDD.Resources.PageObjects.npm
{
    public class Homepage : BasePageObject
    {
        private IWebDriver driver;

        public Homepage(IWebDriver _driver) : base(_driver)
        {
            this.driver = driver;  
        }


        [FindsBy(How = How.CssSelector, Using = "a#nav-enterprise-link")]
        private IWebElement _headerLinkNpmEnterprise;
        [FindsBy(How = How.CssSelector, Using = "a#nav-features-link")]
        private IWebElement _headerLinkFeatures;
        [FindsBy(How = How.CssSelector, Using = "a#nav-pricing-link")]
        private IWebElement _headerLinkPricing;
        [FindsBy(How = How.CssSelector, Using = "a#nav-support-link")]
        private IWebElement _headerLinkSupport;


        [FindsBy(How = How.CssSelector, Using = "input#site-search")]
        private IWebElement _searchBox;

        [FindsBy(How = How.CssSelector, Using = "form#npm-search")]
        private IWebElement _form;

        public void ClickAllHeaderLinks()
        {
            _headerLinkNpmEnterprise.Click();
            _headerLinkFeatures.Click();
            _headerLinkPricing.Click();
            _headerLinkSupport.Click();
        }

        public void ClickFooterColumn01Links()
        {
            ObjectSetup.Driver.FindElement(By.LinkText("Support / Contact Us")).Click();
            ObjectSetup.Driver.FindElement(By.LinkText("Registry Status")).Click();
            ObjectSetup.Driver.Navigate().Back();
            ObjectSetup.Driver.FindElement(By.LinkText("Website Issues")).Click();
            ObjectSetup.Driver.Navigate().Back();
            ObjectSetup.Driver.FindElement(By.LinkText("CLI issues")).Click();
            ObjectSetup.Driver.Navigate().Back();
            ObjectSetup.Driver.FindElement(By.LinkText("Security")).Click();
        }

        public void ClickFooterColumn02Links()
        {
            ObjectSetup.Driver.FindElement(By.LinkText("About npm, Inc")).Click();
            ObjectSetup.Driver.FindElement(By.LinkText("Jobs")).Click();
            ObjectSetup.Driver.FindElement(By.LinkText("npm Weekly")).Click();
            ObjectSetup.Driver.FindElement(By.LinkText("Blog")).Click();
            ObjectSetup.Driver.Navigate().Back();
            ObjectSetup.Driver.FindElement(By.LinkText("Twitter")).Click();
            ObjectSetup.Driver.Navigate().Back();
            ObjectSetup.Driver.FindElement(By.LinkText("GitHub")).Click();
            ObjectSetup.Driver.Navigate().Back();
        }

        public void SearchUsingInput(string search)
        {// COMPARE AGAINST PREVIOUS FRAMEWORK FINDING,
            _searchBox.Click();
            _searchBox.SendKeys(search);
            _form.Submit();
        }

    }
}
