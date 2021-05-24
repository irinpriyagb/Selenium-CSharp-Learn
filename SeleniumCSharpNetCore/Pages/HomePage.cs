using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class HomePage : DriverHelper
    {
        #region Locators
        By loginBy => By.LinkText("Login");
        By logoffBy = By.LinkText("Log off");
        #endregion

        #region Webelements
        IWebElement lnkLogin => Driver.FindElement(loginBy);
        IWebElement lnkLogoff => Driver.FindElement(logoffBy);
        #endregion

        #region Actions
        public void ClickLogin() => lnkLogin.Click();

        public bool IsLogOffExist() => lnkLogoff.Displayed;
        #endregion
    }
}
