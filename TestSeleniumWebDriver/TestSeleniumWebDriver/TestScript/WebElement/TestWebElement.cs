using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.TestScript.WebElement
{
    [TestClass]
    public class TestWebElement
    {
        [TestMethod]
        public void GetElement()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            try
            {
                ObjectRepository.Driver.FindElement(By.TagName("input"));
                ObjectRepository.Driver.FindElement(By.Id("find_bottom"));
                ObjectRepository.Driver.FindElement(By.Id("find_bottom1"));
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
