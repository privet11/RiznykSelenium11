using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace RiznykHomework3
{
    public class Tests
    {
        private readonly IWebDriver driver;
        private static readonly string url= "http://automationpractice.com/index.php";

        public Tests() 
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3); ;
            driver.Navigate().GoToUrl(url);
        }

        [SetUp]
        public void Setup()
        {
        }
        
        [Test] 
        public void PurchaseTest()
        {
            driver.FindElement(By.ClassName("sf-with-ul")).Click();
            driver.FindElement(By.XPath("//*[@id='subcategories']/ul/li[1]/div[1]/a/img")).Click();
            driver.FindElement(By.ClassName("icon-th-list")).Click();
         
            //driver.FindElement(By.ClassName("icon-th-list")).Click();
            //driver.FindElement(By.ClassName("button ajax_add_to_cart_button btn btn-default]"));
            //driver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/div/div/div[1]/div/a[1]/img")).Click();
            //driver.FindElement(By.XPath("//*[@id='add_to_cart']/button")).Click();
        
            Assert.Pass();
        }


        [Test]
        public void SignInTest()
        {
            driver.FindElement(By.ClassName("login")).Click();
            driver.FindElement(By.Id("email")).SendKeys(text: "serjant1212@gmail.com");
            driver.FindElement(By.Id("passwd")).SendKeys(text: "testpass");
            driver.FindElement(By.Id("SubmitLogin")).Click();
            Assert.Pass();
        }
    }
}