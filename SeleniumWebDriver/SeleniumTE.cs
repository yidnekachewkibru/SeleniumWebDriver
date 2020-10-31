using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumWebDriver
{
    class SeleniumTE
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C://Users/yidne/Downloads/Compressed/chromedriver_win32");
        }

        [Test]
        public void test()
        {
            //keyword
            //jSearchSubmit
            driver.Url = "http://akamaijobs.referrals.selectminds.com";
            driver.FindElement(By.Id("keyword")).Clear();
            driver.FindElement(By.Id("keyword")).Click();
            driver.FindElement(By.Id("keyword")).SendKeys("Test");
            //driver.FindElement(By.XPath("//input[@id='jSearchSubmit']")).Click();
            driver.FindElement(By.Id("jSearchSubmit")).Click();

        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
