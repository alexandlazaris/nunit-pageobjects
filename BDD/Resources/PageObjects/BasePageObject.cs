using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.Resources.PageObjects
{
    public class BasePageObject
    {
        public BasePageObject(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}