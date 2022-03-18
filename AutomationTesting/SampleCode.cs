using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
namespace AutomationTesting
{
    [TestClass]
    public class SampleCode
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.demoqa.com";
            driver.Close();
        }
        [TestMethod]
        public void SampleTest2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
            driver.Close();
        }
    }
}
