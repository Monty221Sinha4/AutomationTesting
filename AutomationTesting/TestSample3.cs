using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
namespace AutomationTesting
{
    [TestClass]
    public class TestSample3
    {
        [TestMethod]
        public void SampleTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com")
            driver.FindElement(By.Name("q")).SendKeys("Learn Automation");
            Thread.Sleep(2000);
            driver.Quit();

        }
    }
}
