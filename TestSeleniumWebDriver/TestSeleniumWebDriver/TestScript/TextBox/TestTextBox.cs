using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.TestScript.TextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));

            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_login"));
            //element.SendKeys(ObjectRepository.Config.GetUsername());
            //element = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_password"));
            //element.SendKeys(ObjectRepository.Config.GetPassword());

            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());

            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_login"));
            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_password"));

            //element.Clear();
        }
    }
}
