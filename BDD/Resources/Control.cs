using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.IE;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace BDD.Resources
{
    [TestClass]
    public class Control
    {
        private static InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions option = new InternetExplorerOptions()
            {
                
                IgnoreZoomLevel = true,
                EnsureCleanSession = true
            };
            return option;
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }

        private static IWebDriver GetEdgeDriver()
        {
            IWebDriver driver = new EdgeDriver(@"C:\bin");
            return driver;
        }

        public static void InitSpecflow()
        {
            ObjectSetup.Config = new AppConfigReader();
            switch (ObjectSetup.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectSetup.Driver = GetChromeDriver();
                    break;
                case BrowserType.Firefox:
                    ObjectSetup.Driver = GetFirefoxDriver();
                    break;
                case BrowserType.IE:
                    ObjectSetup.Driver = GetIEDriver();
                    ObjectSetup.Driver.Manage().Window.Maximize();
                    break;
                case BrowserType.Edge:
                    ObjectSetup.Driver = GetEdgeDriver();
                    break;
                default:
                    throw new NotSupportedException("No such driver: " + ObjectSetup.Config.GetBrowser().ToString());
            }

            ObjectSetup.Driver.Manage().Timeouts().PageLoad =
                TimeSpan.FromSeconds(10);
            ObjectSetup.Driver.Manage().Timeouts().ImplicitWait =
                TimeSpan.FromSeconds(10);
        }

        [AssemblyCleanup]
        public static void Finish()
        {
            if(ObjectSetup.Driver != null)
            {
                ObjectSetup.Driver.Close();
                ObjectSetup.Driver.Quit();
            }
        }
    }
}
