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

        public void SigningIn(string testEmail, string testPassword)
        {
            driver.FindElement(email).SendKeys(text: testEmail);
            driver.FindElement(password).SendKeys(text: testPassword);
            driver.FindElement(loginingbutt).Click();
        }
    }
}
