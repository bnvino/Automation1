using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.PageObject;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.TestScript.PageObject
{
    [TestClass]
    public class TestPageObject
    {
        [TestMethod]
        public void TestPage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            LoginPage loginPage = homePage.NavigateToLogin();
            BugDetail bugdetail = loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            //BugDetail bugdetail = enterbug.NavigateToDetail();
            bugdetail.selectFromSeverity("trivial");
        }
    }
}
