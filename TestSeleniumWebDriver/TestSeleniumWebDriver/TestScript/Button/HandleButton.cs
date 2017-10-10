﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.TestScript.Button
{
    [TestClass]
    public class HandleButton
    {
        [TestMethod]
        public void TestButton()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("log_in"));
            //element.Click();
            Console.WriteLine("Enabled : {0}", ButtonHelper.IsButtonEnable(By.Id("log_in")));
            Console.WriteLine("Button Text : {0}", ButtonHelper.GetButtonText(By.Id("log_in")));
            ButtonHelper.ClickButton(By.Id("log_in"));

        }
    }
}
