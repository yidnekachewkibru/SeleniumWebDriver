using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C://Users/yidne/Downloads/Compressed/chromedriver_win32");
            driver.Url = "http://akamaijobs.referrals.selectminds.com/";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);


            driver.FindElement(By.Id("keyword")).SendKeys("Test");
            driver.FindElement(By.)
            driver.FindElement(By.Id("jSearchSubmit")).Click();
        }
    }
}
