using NUnit.Framework;
using SeleniumCSharpNetCore.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCSharpNetCore.Steps
{
    [Binding]
    public class LoginSteps
    {
        private DriverHelper _driverHelper;
        HomePage homePage;
        LoginPage loginPage;

        public LoginSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePage(_driverHelper);
            loginPage = new LoginPage(_driverHelper);
        }
        

        [Given(@"I navigate to the Application")]
        public void GivenINavigateToTheApplication()
        {
            _driverHelper.Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"I click the Login link")]
        public void GivenIClickTheLoginLink()
        {
            homePage.ClickLogin();
        }


        [Given(@"I enter Username and Password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterUsernameAndPassword((String)data.UserName, (String)data.Password);
        }

        [Given(@"I click Login")]
        public void GivenIClickLogin()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I should see user logged in to the Application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            Assert.IsTrue(homePage.IsLogOffExist());
        }
    }
}
