using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
namespace AutomationTesting
{
    [TestClass]
    public class TestSample4
    {
        [TestMethod]
        public void SampleTest2()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("Start Maximed");
            IWebDriver webDriver = new ChromeDriver(options);
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            webDriver.Navigate().GoToUrl("http://www.google.com");
            IWebElement textField = webDriver.FindElement(By.Name("q"));
            textField.SendKeys("Automation testing");
            IWebElement searchButton = webDriver.FindElement(By.CssSelector("Input[value='Google Search']"));
            searchButton.Click();
            webDriver.Dispose();

        }
    }
}
