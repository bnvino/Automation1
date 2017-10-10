using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.PageObject;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.StepDefinition
{
    [Binding]
    public sealed class Argument
    {

        private HomePage hPage;
        private LoginPage lPage;
        private BugDetail bPage;
        #region Give
        [Given(@"User is at Home Page wit url ""(.*)""")]
        public void GivenUserIsAtHomePageWitUrl(string url)
        {
            NavigationHelper.NavigateToUrl(url);
        }

        #endregion

        #region When
        [When(@"I Click on ""(.*)"" link")]
        public void WhenIClickOnLink(string LinkText)
        {
            hPage = new HomePage(ObjectRepository.Driver);
            lPage = hPage.NavigateToLogin();
        }

        [When(@"I provid ""(.*)"", ""(.*)"" and click on Login button")]
        public void WhenIProvidAndClickOnLoginButton(string username, string password)
        {
            ObjectRepository.bPage = ObjectRepository.lPage.Login(username, password);
        }

        //[When(@"I click on Logout button at enter bug page")]
        //public void WhenIClickOnLogoutButtonAtEnterBugPage()
        //{
        //    bPage.Logout();
        //}


        [When(@"I provide the severity, Hardware, platform, summary and Desc")]
        public void WhenIProvideTheSeverityHardwarePlatformSummaryAndDesc(Table table)
        {
            foreach(var row in table.Rows)
            {
                bPage.SelectFromCombo(row["Severity"],row["Hardware"],row["OS"]);
                bPage.TypeIn(row["Summary"],row["Desc"]);
            }
        }

        [When(@"I click on Logout button at enter bug page")]
        [When(@"I click on Logout button at bug detail page")]
        public void WhenIClickOnLogoutButtonAtBugDetailPage()
        {
            bPage.Logout();
        }

        [When(@"I provide the ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" and ""(.*)""")]
        public void WhenIProvideTheAnd(string severity, string hardware, string platform, string summary, string desc)
        {
            bPage.SelectFromCombo(severity, hardware, platform);
            bPage.TypeIn(summary, desc);
        }



        #endregion

        #region

        [When(@"click on Submit button in Page")]
        public void WhenClickOnSubmitButtonInPage()
        {
            bPage.ClickSubmit();
        }

        #endregion


        #region Then
        [Then(@"User should be at Login Page with title ""(.*)""")]
        public void ThenUserShouldBeAtLoginPageWithTitle(string title)
        {
            Assert.AreEqual(title, lPage.Title);
        }

        [Then(@"User should be at Enter Bug Page with title ""(.*)""")]
        public void ThenUserShouldBeAtEnterBugPageWithTitle(string title)
        {
            Assert.AreEqual(title, bPage.Title);
        }



        #endregion

    }
}
