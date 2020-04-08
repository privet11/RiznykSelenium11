using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiznykHomework3.PageObject
{
    class LoginPage: BasePgObj
    {
        private static readonly By email = By.Id("email");
        private static readonly By password = By.Id("passwd");
        private static readonly By loginingbutt= By.Id("SubmitLogin");

        public LoginPage(IWebDriver driver) : base(driver)
        { 
        
        }

        public void SigningIn()
        {
            driver.FindElement(email).SendKeys(text: "serjant1212@gmail.com");
            driver.FindElement(password).SendKeys(text: "testpass");
            driver.FindElement(loginingbutt).Click();
        }
    }
}
