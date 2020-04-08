using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiznykHomework3.PageObject
{
    class MainHeader: BasePgObj
    {
        private static readonly By loginButton = By.ClassName("login");


        public MainHeader(IWebDriver driver) : base(driver)
        { }

        public LoginPage ClickOnSignIn()
        {
            driver.FindElement(loginButton).Click();
            return new LoginPage(driver);
        }
    }
}
