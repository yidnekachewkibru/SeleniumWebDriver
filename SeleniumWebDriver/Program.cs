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
            IWebElement option = driver.FindElement(By.XPath("//*[@id='location_facet_chzn']")); // Option is visible and ok to use
            driver.FindElement(By.XPath("//*[@id='location_facet_chzn_c_12']")).Click(); // Dropdown closing hides the option
            option.Click(); // This option is no longer iteractable
            driver.FindElement(By.XPath("//*[@id='location_facet_chzn']")).SendKeys("PL-Krakow");
            driver.FindElement(By.Id("jSearchSubmit")).Click();
        }
    }
}
