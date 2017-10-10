using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
        }

        internal static void NavigateToUrl(object objecRepository)
        {
            throw new NotImplementedException();
        }
    }
}
