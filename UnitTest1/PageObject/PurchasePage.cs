using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiznykHomework3.PageObject
{
    class PurchasePage : BasePgObj
    {
        private static readonly By tops = By.XPath("//*[@id='subcategories']/ul/li[1]/div[1]/a/img");
        private static readonly By inlist = By.ClassName("icon-th-list");

        public PurchasePage(IWebDriver driver) : base(driver)
        {

        }

        public void TopsViewing()
        {
            driver.FindElement(tops).Click();
            driver.FindElement(inlist).Click();
        }
    }
}
