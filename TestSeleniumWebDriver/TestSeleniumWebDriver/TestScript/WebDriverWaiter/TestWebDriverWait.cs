using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.Settings;
using OpenQA.Selenium.Support.UI;

namespace TestSeleniumWebDriver.TestScript.WebDriverWaiter
{
    [TestClass]
    public class TestWebDriverWait
    {
        [TestMethod]
        public void TestWait()
        {
            //ObjectRepository.Driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(1));
            NavigationHelper.NavigateToUrl("https://www.udemy.com/courses");
            //ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));
            TextBoxHelper.TypeInTextBox(By.Id("q"), "C#");
        }

        [TestMethod]
        public void TestDynamicWait()
        {
            NavigationHelper.NavigateToUrl("https://www.udemy.com/");
            ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(50));
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            //Console.WriteLine(wait.Until(waitforTitle()));
            IWebElement element = wait.Until(waitforElement());
            element.SendKeys("C#");


        }

        private Func<IWebDriver,bool> waitforSearchbox()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for Search Box");
                return x.FindElements(By.Id("q")).Count == 1;
            });
        }

        private Func<IWebDriver, string> waitforTitle()
        {
            return ((x)=>
            {
                if(x.Title.Contains("Main"))
                    return x.Title;
                return null;
            });
        }

        private Func<IWebDriver,IWebElement> waitforElement()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for element");
                if (x.FindElements(By.Id("q")).Count == 1)
                    return x.FindElement(By.Id("q"));
                return null;
            });
        }
    }
}
