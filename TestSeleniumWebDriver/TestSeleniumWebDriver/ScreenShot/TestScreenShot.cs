using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.ScreenShot
{
    [TestClass]
    public class TestScreenShot
    {
        [TestMethod]
        public void ScreenShot()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));

            //Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            //screen.SaveAsFile("screen.jpeg", ScreenshotImageFormat.Jpeg);
            GenericHelper.TakeScreenShot();

            GenericHelper.TakeScreenShot("Test.jpeg");
        }
    }
}
