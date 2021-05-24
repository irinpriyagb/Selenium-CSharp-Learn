using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class HomePage
    {
        private DriverHelper _driverHelper;
        public HomePage(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        #region Locators
        By loginBy => By.LinkText("Login");
        By logoffBy = By.LinkText("Log off");
        private DriverHelper driverHelper;
        #endregion

        #region Webelements
        IWebElement lnkLogin => _driverHelper.Driver.FindElement(loginBy);
        IWebElement lnkLogoff => _driverHelper.Driver.FindElement(logoffBy);
        #endregion

        #region Actions
        public void ClickLogin() => lnkLogin.Click();

        public bool IsLogOffExist() => lnkLogoff.Displayed;
        #endregion
    }
}
