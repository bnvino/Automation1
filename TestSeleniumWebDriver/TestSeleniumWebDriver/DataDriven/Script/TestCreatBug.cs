using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.PageObject;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.DataDriven.Script
{
    [TestClass]
    public class TestCreatBug
    {

        private TestContext _testContext;

        public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"D:\VisualStudioProjects\Automation\Data\CreateData.csv", "CreateData#csv",DataAccessMethod.Sequential)]
        public void TestBug()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage hpPage = new HomePage(ObjectRepository.Driver);
            LoginPage loginPage = hpPage.NavigateToLogin();
            var bDetail = loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            bDetail.SelectFromCombo(TestContext.DataRow["Severity"].ToString(), TestContext.DataRow["Hardware"].ToString(), TestContext.DataRow["OS"].ToString());
            bDetail.TypeIn(TestContext.DataRow["Summary"].ToString(), TestContext.DataRow["Desc"].ToString());
            bDetail.ClickSubmit();
            bDetail.Logout();
            Thread.Sleep(5000);


        }
    }
}
