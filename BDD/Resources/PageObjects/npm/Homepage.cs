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
    public class Homepage
    {
        private IWebDriver driver;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;  
        }

        [FindsBy(How = How.CssSelector, Using = "input#site-search")]
        private IWebElement _searchBox;

        [FindsBy(How = How.CssSelector, Using = "form#npm-search")]
        private IWebElement _form;

        public void searchUsingInput(string search)
        {// COMPARE AGAINST PREVIOUS FRAMEWORK FINDING,
            _searchBox.Click();
            _searchBox.SendKeys(search);
            _form.Submit();
        }

    }
}
