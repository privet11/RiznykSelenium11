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

        [Test]
        public void SignInTest()
        {
            MainHeader header = new MainHeader(driver);
            LoginPage signInPage = header.ClickOnSignIn();
            signInPage.SigningIn();

            Assert.Pass();
        }

        [Test] 
        public void PurchaseTest()
        {
            driver.FindElement(By.ClassName("sf-with-ul")).Click();
            driver.FindElement(By.XPath("//*[@id='subcategories']/ul/li[1]/div[1]/a/img")).Click();
            driver.FindElement(By.ClassName("icon-th-list")).Click();
        
            Assert.Pass();
        }


    
    }
}