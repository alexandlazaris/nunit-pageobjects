using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.Resources.PageObjects.npm
{
    public class Account : BasePageObject
    {
        private IWebDriver _driver;
        public Account(IWebDriver _driver) : base(_driver)
        {
            this._driver = _driver;
            PageFactory.InitElements(ObjectSetup.Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#name")]
        private IWebElement _inputUsername;
        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement _inputPassword;
        [FindsBy(How = How.CssSelector, Using = "div.pane.mbxxl button")]
        private IWebElement _btnSubmit;
        [FindsBy(How = How.CssSelector, Using = "div.alert-error")]
        private IWebElement _messageError;

        public void InputUsername(string text)
        {
            _inputUsername.SendKeys(text);
        }

        public void InputPassword(string text)
        {
            _inputPassword.SendKeys(text);
        }

        public void PressSubmit()
        {
            _btnSubmit.Click();
        }

        public bool IsErrorPresent()
        {
            return _messageError.Displayed;
        }
    }
}
