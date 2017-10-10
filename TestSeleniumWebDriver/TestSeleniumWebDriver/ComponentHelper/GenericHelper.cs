using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.ComponentHelper
{
    public class GenericHelper
    {

        //private static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(GenericHelper));
        public static bool IsElementPresent(By Locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(Locator).Count == 1;
            }
            catch(Exception)
            {
                return false;
            }
            
        }

        private static Func<IWebDriver, IWebElement> WaitForWebElementInPageFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return x.FindElement(locator);
                return null;
            });
        }

        public static WebDriverWait GetWebdriverWait(TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout)
            {
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            //Logger.Info(" Wait Object Created ");
            return wait;
        }

        public static IWebElement WaitForWebElementInPage(By locator, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
            //Logger.Info(" Setting the Explicit wait to 1 sec ");
            var wait = GetWebdriverWait(timeout);
            var flag = wait.Until(WaitForWebElementInPageFunc(locator));
            //Logger.Info(" Setting the Explicit wait Configured value ");
            ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeout()));
            return flag;
        }

        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator))
                return ObjectRepository.Driver.FindElement(Locator);
            else
                throw new NoSuchElementException("Element Not Found : " + Locator.ToString());
        }

        public static void TakeScreenShot(string filename = "Screen")
        {
            Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            if (filename.Equals("Screen"))
            {
                filename =  filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".jpeg";
                screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
                return;
            }
            else
            {
                screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
            }
            
        }
    }
}
