using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiznykHomework3.PageObject
{
    class MainHeader: BasePgObj
    {
        private static readonly By loginButton = By.ClassName("login");
        private static readonly By womanButton = By.ClassName("sf-with-ul");

        public MainHeader(IWebDriver driver) : base(driver)
        { }

        public LoginPage ClickOnSignIn()
        {
            driver.FindElement(loginButton).Click();
            return new LoginPage(driver);
        }

        public PurchasePage ClickOnWoman()
        {
            driver.FindElement(womanButton).Click();
            return new PurchasePage(driver);
        }
    }
}
