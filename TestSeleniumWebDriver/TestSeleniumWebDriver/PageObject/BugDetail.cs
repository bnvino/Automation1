using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWebDriver.BaseClasses;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.PageObject
{
    public class BugDetail : PageBase
    {
        #region WebElement

        private IWebDriver driver;
        //private By severityDropDown = By.Id("bug_severity");
        [FindsBy(How = How.Id, Using = "bug_severity")]
        private IWebElement severityDropDown;

        [FindsBy(How = How.Id, Using = "rep_platform")]
        private IWebElement Hardware;

        [FindsBy(How = How.Id, Using = "op_sys")]
        private IWebElement OpSys;

        [FindsBy(How = How.Id, Using = "short_desc")]
        private IWebElement ShortDesc;

        [FindsBy(How = How.Id, Using = "comment")]
        private IWebElement comment;


        [FindsBy(How = How.Id, Using = "commit")]
        private IWebElement commit;

        #endregion

        public BugDetail(IWebDriver _driver) : base(_driver)
        {
            //PageFactory.InitElements(ObjectRepository.Driver, this);
            this.driver = _driver;
        }

        #region Actiions
        public void selectFromSeverity(string value)
        {
            DropDownListHelper.SelectElement(severityDropDown, value);
        }
        public void SelectFromCombo(string severity = null, string hardware = null, string os = null)
        {
            if (severity != null)
                DropDownListHelper.SelectElement(severityDropDown, severity);

            if (severity != null)
                DropDownListHelper.SelectElement(Hardware, hardware);

            if (severity != null)
                DropDownListHelper.SelectElement(OpSys, os);
        }

        public void TypeIn(string summary = null, string desc = null)
        {
            if (summary != null)
                ShortDesc.SendKeys(summary);
            if (desc != null)
                comment.SendKeys(desc);

        }

        public void ClickSubmit()
        {
            commit.Click();
            GenericHelper.WaitForWebElementInPage(By.Id("bugzilla-body"), TimeSpan.FromSeconds(30));
        }

        public new HomePage Logout()
        {
            base.Logout();
            return new HomePage(driver);

        }
        #endregion


        #region Navigation
        #endregion


    }
}
