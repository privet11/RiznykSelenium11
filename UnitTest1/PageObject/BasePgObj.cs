using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiznykHomework3.PageObject
{
    class BasePgObj
    {
        protected readonly IWebDriver driver;
        public static readonly string url = "http://automationpractice.com/index.php";
        public static readonly TimeSpan implicitWait = TimeSpan.FromSeconds(3);
        protected BasePgObj(IWebDriver driver1)
        {
            driver = driver1;
        }
    }
}
