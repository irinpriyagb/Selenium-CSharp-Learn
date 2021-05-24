using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpNetCore.Pages;
using System;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
            
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomoto");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            
            //comboBox.SendKeys(Keys.Enter);
            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();
            homePage.ClickLogin();
            loginPage.Login("admin", "password");
            Assert.IsTrue(homePage.IsLogOffExist());
        }
    }
}