using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.Resources.PageObjects
{
    public class Homepage
    {
        private IWebDriver driver;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "div#hplogo")]
        public IWebElement logo;

        [FindsBy(How = How.CssSelector, Using = "div input.gsfi:first-of-type")]
        private IWebElement searchBox;

        [FindsBy(How = How.CssSelector, Using = "button.sbico-c")]
        private IWebElement searchButton;

        [FindsBy(How = How.CssSelector, Using = "div.srg div.g")]
        [CacheLookup]
        private IWebElement searchResults;

        public void SearchText(string text)
        {
            searchBox.SendKeys(text);
            searchButton.Click();
        }

        public bool AtLeastOneSearchResult()
        {
            if (!(driver.FindElements(By.CssSelector("div.srg div.g")).Count > 1))
                return false;
            else
                return true;
        }
    }
}
