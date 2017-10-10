using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.TestScript.BrowserActions
{
    [TestClass]
    public class TestBrowerActions
    {
        [TestMethod]
        public void TestActions()
        {
            NavigationHelper.NavigateToUrl("https://www.udemy.com/bdd-with-selenium-webdriver-and-speckflow-using-c/learn/v4/overview");
            LinkHelper.ClickLink(By.LinkText("Try Udemy for Business"));
            BrowserHelper.GoBack();
            BrowserHelper.Forward();
            BrowserHelper.Refresh();

        }
    }
}
