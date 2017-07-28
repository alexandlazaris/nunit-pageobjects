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

        [FindsBy(How = How.CssSelector, Using = "ul.search-results > div[data-reactid]")]
        private IList<IWebElement> allSearchResults;
        
        public void printElements()
        {
            String[] allText = new String[allSearchResults.Count];
            int i = 0;
            foreach (IWebElement element in allSearchResults)
            {
                Console.WriteLine(element.Text);
                Console.WriteLine(allText[i]);
                allText[i++] = element.Text;
                
            }
        }

    }
}
