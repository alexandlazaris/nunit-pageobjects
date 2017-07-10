using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace BDD.Resources.Drivers
{
    public class WebDrivers
    {
        IWebDriver chrome = new ChromeDriver();
        IWebDriver ff = new FirefoxDriver();
        IWebDriver ie11= new InternetExplorerDriver();
        IWebDriver edge = new EdgeDriver();

        public void CreateChromeDriver()
        {

        }

        public void LoadInAllDrivers()
        {

        }
    }
}
