using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class LoginPage
    {
        private DriverHelper _driverHelper;
        public LoginPage(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        #region Locators
        By usernameBy => By.Id("UserName");
        By passwordBy => By.Id("Password");
        By loginBy => By.XPath("//input[@value='Log in']");
        #endregion

        #region WebElements
        IWebElement Username => _driverHelper.Driver.FindElement(usernameBy);
        IWebElement Password => _driverHelper.Driver.FindElement(passwordBy);
        IWebElement LoginBtn => _driverHelper.Driver.FindElement(loginBy);

        public DriverHelper DriverHelper { get; }
        #endregion

        #region Actions
        public void EnterUsernameAndPassword(String name, String pass)
        {
            Username.SendKeys(name);
            Password.SendKeys(pass);
        }

        public void ClickLogin()
        {
            LoginBtn.Click();
        }
        #endregion
    }
}
