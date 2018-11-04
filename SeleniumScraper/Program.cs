using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://google.com");

            driver.FindElement(By.Name("q")).SendKeys("Charleston, SC");

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
