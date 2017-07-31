using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDD.Resources
{
    public class Helper
    {
        private static IWebElement _element;

        public static void ClickElement(IWebElement element)  
        {
            CheckSingleElementPresent(element);
            element.Click();
        }

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

        public static bool CheckSingleElementPresent(IWebElement element)//By element)
        {
            try
            {
                return element.Enabled;
                //return ObjectSetup.Driver.FindElements(element).Count == 1;
            }
            catch(NoSuchElementException)
            {
                TakeScreenshot();
                return false;
            }
        }

        public static bool CheckMultipleElementPresent(By element)
        {
            try
            {
                return ObjectSetup.Driver.FindElements(element).Count > 1;
            }
            catch (NoSuchElementException)
            {
                TakeScreenshot();
                return false;
            }
        }

        /*public static IWebElement GetSingleElement(By element)
        {
            if (CheckSingleElementPresent(element))
                return ObjectSetup.Driver.FindElement(element);
            else
                throw new NoSuchElementException("Element not found: " + element.ToString());
        }*/

        /*public static IList <IWebElement> GetMultipleElement(By element)
        {
            if (CheckSingleElementPresent(element))
                return ObjectSetup.Driver.FindElements(element);
            else
                throw new NoSuchElementException("Element not found: " + element.ToString());
        }*/

        public static void TakeScreenshot()
        {
            Screenshot ss = ((ITakesScreenshot)ObjectSetup.Driver).GetScreenshot();
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;
            ss.SaveAsFile(@"..\..\Screenshots\error.jpg", ScreenshotImageFormat.Jpeg);
        }
    }
}
