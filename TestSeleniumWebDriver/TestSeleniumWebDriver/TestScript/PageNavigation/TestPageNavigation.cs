using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            //INavigation page = ObjectRepository.Driver.Navigate();
            //page.GoToUrl(ObjectRepository.Config.GetWebsite());
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }
    }
}
