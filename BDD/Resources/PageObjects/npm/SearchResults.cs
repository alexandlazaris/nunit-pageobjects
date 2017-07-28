using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.Resources.PageObjects.npm
{
    public class SearchResults
    {
        private IWebDriver driver;

        public SearchResults(IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "ul.search-results > div[data-reactid] h3")]
        private IList<IWebElement> _searchResultTitles;

        [FindsBy(How = How.CssSelector, Using = "ul.search-results > div[data-reactid] a:first-child")]
        private IList<IWebElement> _searchResultLinks;

        public void PrintResultHeaders()
        {
            foreach (IWebElement element in _searchResultTitles)
            {
                Console.WriteLine(element.Text);
            }
        }

        public void SelectAResultLink(int index)
        {
            _searchResultLinks[index].Click();
        }
    }
}
