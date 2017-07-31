using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.Resources
{
    public class Helper
    {
        private static IWebElement element;

        public static void ScrollDown(By element)
        { 
            ObjectSetup.Driver.FindElement(element).SendKeys(Keys.PageDown);
            ObjectSetup.Driver.FindElement(element).SendKeys(Keys.PageDown);
            ObjectSetup.Driver.FindElement(element).SendKeys(Keys.PageDown);
            ObjectSetup.Driver.FindElement(element).SendKeys(Keys.PageDown);
            ObjectSetup.Driver.FindElement(element).SendKeys(Keys.PageDown);
            ObjectSetup.Driver.FindElement(element).SendKeys(Keys.PageDown);
            ObjectSetup.Driver.FindElement(element).SendKeys(Keys.PageDown);
            ObjectSetup.Driver.FindElement(element).SendKeys(Keys.PageDown);
            ObjectSetup.Driver.FindElement(element).SendKeys(Keys.PageDown);
        }
    }
}
