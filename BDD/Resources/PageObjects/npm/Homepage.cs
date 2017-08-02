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
        private IWebDriver _driver;

        public Homepage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "a#nav-enterprise-link")]
        private IWebElement _headerLinkNpmEnterprise;
        [FindsBy(How = How.CssSelector, Using = "a#nav-features-link")]
        private IWebElement _headerLinkFeatures;
        [FindsBy(How = How.CssSelector, Using = "a#nav-pricing-link")]
        private IWebElement _headerLinkPricing;
        [FindsBy(How = How.CssSelector, Using = "a#nav-docs-link")]
        private IWebElement _headerLinkDocument;
        [FindsBy(How = How.CssSelector, Using = "a#nav-support-link")]
        private IWebElement _headerLinkSupport;
        [FindsBy(How = How.CssSelector, Using = "ul.user-info-salutation li:nth-child(2) a")]
        private IWebElement _btnLogin;
        [FindsBy(How = How.CssSelector, Using = "input#site-search")]
        private IWebElement _searchBox;
        [FindsBy(How = How.CssSelector, Using = "form#npm-search")]
        private IWebElement _form;

        public void ClickAllHeaderLinks()
        {
            Helper.ClickElement(_headerLinkNpmEnterprise);
            Helper.ClickElement(_headerLinkFeatures);
            Helper.ClickElement(_headerLinkPricing);
            Helper.ClickElement(_headerLinkDocument);
            ObjectSetup.Driver.Navigate().Back();
            Helper.ClickElement(_headerLinkSupport);
            /*_headerLinkNpmEnterprise.Click - HOW IT LOOKED BEFORE HELPER CLASS*/
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
            ObjectSetup.Driver.FindElement(By.LinkText("npm loves you")).Click();
        }

        public void SearchUsingInput(string search)
        {
            _searchBox.Click();
            _searchBox.SendKeys(search);
            _form.Submit();
        }

        public Account SelectLogin()
        {
            _btnLogin.Click();
            return new Account(_driver);
        }
    }
}
