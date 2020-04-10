using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using RiznykHomework3.PageObject;

namespace RiznykHomework3
{
    public class Tests
    {
        private readonly IWebDriver driver;

        public Tests() 
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = BasePgObj.implicitWait; ;
            driver.Navigate().GoToUrl(BasePgObj.url);
        }

        [SetUp]
        public void Setup()
        {
        }

        [TestCase("serjant1212@gmail.com", "testpass")]
        public void SignInTest(string testEmail, string testPassword)
        {
            MainHeader header = new MainHeader(driver);
            LoginPage signInPage = header.ClickOnSignIn();
            signInPage.SigningIn(testEmail, testPassword);

            Assert.Pass();
        }

        [Test] 
        public void PurchaseTest()
        {
            MainHeader header = new MainHeader(driver);
            PurchasePage purchPage = header.ClickOnWoman();
            purchPage.TopsViewing();
        
            Assert.Pass();
        }


    
    }
}