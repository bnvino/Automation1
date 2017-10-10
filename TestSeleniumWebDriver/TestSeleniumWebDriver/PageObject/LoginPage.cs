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
    public class LoginPage : PageBase
    {
        #region WebElement

        //private By LoginTextBox = By.Id("Bugzilla_login");
        //private By PassTextBox = By.Id("Bugzilla_password");
        //private By LoginButton = By.Id("log_in");
        //private By HomeLink = By.LinkText("Home");

        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "Bugzilla_login")]
        private IWebElement UserNameTextBox;

        [FindsBy(How = How.Id, Using = "Bugzilla_password")]
        private IWebElement PassTextBox;

        [FindsBy(How = How.Id, Using = "log_in")]
        [CacheLookup]
        private IWebElement LoginButton;

        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink;
        #endregion

        //public LoginPage()
        //{
        //    PageFactory.InitElements(ObjectRepository.Driver, this);
        //}

        public LoginPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }


        #region Actions

        public BugDetail Login(String username, string password)
        {
            //ObjectRepository.Driver.FindElement(LoginTextBox).SendKeys(username);
            //ObjectRepository.Driver.FindElement(PassTextBox).SendKeys(password);
            //ObjectRepository.Driver.FindElement(LoginButton).Click();
            UserNameTextBox.SendKeys(username);
            PassTextBox.SendKeys(password);
            LoginButton.Click();
            return new BugDetail(driver);

        }
        #endregion


        #region Navigation

        public void NavigateToHome()
        {
            //ObjectRepository.Driver.FindElement(HomeLink).Click();
            HomeLink.Click();
        }
        #endregion
    }
}
