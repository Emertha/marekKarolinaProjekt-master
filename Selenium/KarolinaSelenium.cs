using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
   public class KarolinaSelenium
    {

        private string XkomUrl = "https://www.x-kom.pl/";

        IWebDriver _driver;
        [SetUp]
        public void StartBrowser()
        {
            _driver = new InternetExplorerDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Search_Input_Website()
        {
            _driver.Navigate().GoToUrl(XkomUrl);
            _driver.FindElement(By.CssSelector("input[type='text']")).Click();
            _driver_SendKeys("Komputer");
            _driver.FindElement(By.CssSelector("button[type='sc-152fwhi-7 iEstPH']")).Click();

        }

        [Test]
        public void Click_HotSale()
        {
            _driver.Navigate().GoToUrl(XkomUrl);
            _driver.FindElement(By.CssSelector("div[id='hotShot']")).Click();

        }


        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }

    }
}
