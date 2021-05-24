using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class LoginPage : DriverHelper
    {
        #region Locators
        By usernameBy => By.Id("UserName");
        By passwordBy => By.Id("Password");
        By loginBy => By.XPath("//input[@value='Log in']");
        #endregion

        #region WebElements
        IWebElement Username => Driver.FindElement(usernameBy);
        IWebElement Password => Driver.FindElement(passwordBy);
        IWebElement LoginBtn => Driver.FindElement(loginBy);
        #endregion

        #region Actions
        public void Login(String name, String pass)
        {
            Username.SendKeys(name);
            Password.SendKeys(pass);
            LoginBtn.Click();
        }
        #endregion
    }
}
