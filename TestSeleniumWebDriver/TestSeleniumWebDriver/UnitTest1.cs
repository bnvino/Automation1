using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using TestSeleniumWebDriver.Interfaces;
using TestSeleniumWebDriver.Configuration;

namespace TestSeleniumWebDriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //IConfig config = new AppConfigReader();
            //Console.WriteLine("Browser : {0}", config.GetBrowser());
            //Console.WriteLine("Username : {0}", config.GetUsername());
            //Console.WriteLine("Password : {0}", config.GetPassword());
        }
    }
}
