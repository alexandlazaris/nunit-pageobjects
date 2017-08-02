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
        [FindsBy(How = How.CssSelector, Using = "#fullname")]
        private IWebElement _inputFullname;
        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement _inputPassword;
        [FindsBy(How = How.CssSelector, Using = "#email")]
        private IWebElement _inputEmail;
        [FindsBy(How = How.CssSelector, Using = "form button[type=submit]:nth-child(-n+2)")]
        public IWebElement _btnSubmit;
        [FindsBy(How = How.CssSelector, Using = "div.alert-error")]
        private IWebElement _messageError;

        public void SelectSignUp()
        {
            _driver.FindElement(By.LinkText("sign up")).Click();
        }

        public void InputUsername(string text)
        {
            _inputUsername.SendKeys(text);
        }

        public void InputFullname(string text)
        {
            _inputFullname.SendKeys(text);
        }

        public void InputPassword(string text)
        {
            _inputPassword.SendKeys(text);
        }

        public void InputEmail(string text)
        {
            _inputEmail.SendKeys(text);
        }

        public void AgreeTermsAndConditions()
        {
            IWebElement element = _driver.FindElement(By.CssSelector("#npmweekly"));
            if (!(element.Selected))
                element.Click();
            element = _driver.FindElement(By.CssSelector("#eula-agreement-cbx"));
            if (!(element.Selected))
                element.Click();
        }

        public void SelectSubmit()
        {
            _btnSubmit.Click();
        }

        public bool IsErrorPresent()
        {
            return _messageError.Displayed;
        }
    }
}
