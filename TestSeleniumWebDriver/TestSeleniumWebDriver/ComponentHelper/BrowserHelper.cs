using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.ComponentHelper
{
    public class BrowserHelper
    {
        public static void BrowswerMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();

        }

        public static void GoBack()
        {
            ObjectRepository.Driver.Navigate().Back();

        }
        public static void Forward()
        {
            ObjectRepository.Driver.Navigate().Forward();

        }

        public static void Refresh()
        {
            ObjectRepository.Driver.Navigate().Refresh();

        }
    }
}
