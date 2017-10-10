using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.TestScript.CheckBox
{
    [TestClass]
    public class TestCheckBox
    {
        [TestMethod]
        public void TextCheckBox()
        {

            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));

            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());

            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_login"));
            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_password"));

            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_restrictlogin"));
            //element.Click();

            Console.WriteLine(CheckBoxHelper.isCheckedBoxChecked(By.Id("Bugzilla_restrictlogin")));

            CheckBoxHelper.CheckedCheckBox(By.Id("Bugzilla_restrictlogin"));
            Console.WriteLine(CheckBoxHelper.isCheckedBoxChecked(By.Id("Bugzilla_restrictlogin")));
        }
    }
}
