using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.IO;
using System.Reflection;

namespace Section18
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GooglePage()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com/");
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        private object GetChromeDriver2()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}
