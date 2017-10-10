using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.BaseClasses;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.PageObject
{
    public class HomePage : PageBase
    {
        # region WebElement

        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "quicksearch_main")]
        private IWebElement QuickSearchTextBox;

        [FindsBy(How = How.Id, Using = "find")]
        private IWebElement QuickSearchBtn;

        [FindsBy(How = How.LinkText, Using = "File a Bug")]
        private IWebElement FileABugLink;
        //private By QuickSearchTextBox = By.Id("quicksearch_main");
        //private By QuickSearchBtn = By.Id("find");
        //private By FileABugLink = By.LinkText("File a Bug");
        #endregion

        public HomePage(IWebDriver _driver) : base(_driver)
        {
            //PageFactory.InitElements(ObjectRepository.Driver, this);
            this.driver = _driver;
        }

        #region Actions

        public void QuickSearch(string text)
        {
            //ObjectRepository.Driver.FindElement(QuickSearchTextBox).SendKeys(text);
            //ObjectRepository.Driver.FindElement(QuickSearchBtn).Click();

            QuickSearchTextBox.SendKeys(text);
            QuickSearchBtn.Click();
        }

        #endregion

        #region Navigation

        public LoginPage NavigateToLogin()
        {
            //ObjectRepository.Driver.FindElement(FileABugLink).Click();
            FileABugLink.Click();
            return new LoginPage(driver);
        }
        #endregion

    }
}
