using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.Interfaces;
using TestSeleniumWebDriver.PageObject;

namespace TestSeleniumWebDriver.Settings
{
    public class ObjectRepository
    { 
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

        public static HomePage hPage;
        public static LoginPage lPage;
        public static BugDetail bPage;
    }
}
