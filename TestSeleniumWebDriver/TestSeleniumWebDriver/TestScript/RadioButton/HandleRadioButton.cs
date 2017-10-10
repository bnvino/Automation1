using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.TestScript.RadioButton
{
    [TestClass]
    public class HandleRadioButton
    {
        [TestMethod]
        public void TestRadio()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            IWebElement element = ObjectRepository.Driver.FindElement(By.XPath(".//a[@id='enter_bug']/span"));
            Console.WriteLine("Text : {0}", element.Text);
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));

            LinkHelper.ClickLink(By.XPath(".//div[@id='header']/ul[1]/li[9]/a"));
            LinkHelper.ClickLink(By.XPath(".//dt[@id='parameters']/a"));

            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("ssl_redirect-on"));
            //element.Click();
            Console.WriteLine("selected : {0} ", RadioButtonHelper.IsRadioButtonSelected(By.Id("ssl_redirect-off")));
            RadioButtonHelper.ClickRadioButton(By.Id("ssl_redirect-on"));
            Console.WriteLine("selected : {0} ", RadioButtonHelper.IsRadioButtonSelected(By.Id("ssl_redirect-on")));
        }
    }
}
