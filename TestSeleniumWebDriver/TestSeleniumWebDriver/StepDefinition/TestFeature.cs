using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
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
    public sealed class TestFeature
    {
        private HomePage hPage;
        private LoginPage lPage;
        private BugDetail bPage;
        #region Given
        [Given(@"User is at Home Page")]
        public void GivenUserIsAtHomePage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }


        [Given(@"File  a Bug should be visible")]
        public void GivenFileABugShouldBeVisible()
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("enter_bug")));
        }

        #endregion

        #region When

        [When(@"I Click on File a Bug link")]
        public void WhenIClickOnFileABugLink()
        {
            ObjectRepository.hPage = new HomePage(ObjectRepository.Driver);
            ObjectRepository.lPage = ObjectRepository.hPage.NavigateToLogin();

        }

        [When(@"I provid username, password and click on Login button")]
        public void WhenIProvidUsernamePasswordAndClickOnLoginButton()
        {
            bPage = lPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
        }

        [When(@"I click on Logout button")]
        public void WhenIClickOnLogoutButton()
        {
            ObjectRepository.bPage.Logout();
        }

        [When(@"I provide the severity, Hardware, platfor and summary")]
        public void WhenIProvideTheSeverityHardwarePlatforAndSummary()
        {
            bPage.SelectFromCombo("critical", "Macintosh", "Other");
            bPage.TypeIn("Summarry one", "Description one");
        }


        #endregion

        #region AND
        [When(@"click on Submit button")]
        public void WhenClickOnSubmitButton()
        {
            bPage.ClickSubmit();
        }

        #endregion

        #region Then

        [Then(@"User should be at Login Page")]
        public void ThenUserShouldBeAtLoginPage()
        {
            Assert.AreEqual("Log in to Bugzilla",ObjectRepository.lPage.Title);
        }


        [Then(@"User should be at Enter Bug Page")]
        public void ThenUserShouldBeAtEnterBugPage()
        {
            Assert.AreEqual("Enter Bug: TestProduct", ObjectRepository.bPage.Title);
        }

        [Then(@"User should be logged out and should be at Home Page")]
        public void ThenUserShouldBeLoggedOutAndShouldBeAtHomePage()
        {

            Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("welcome")));
        }

        [Then(@"Bug should get created and")]
        public void ThenBugShouldGetCreatedAnd()
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("commit_top")));
        }

        [Then(@"USer should be at search page")]
        public void ThenUSerShouldBeAtSearchPage()
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("commit_top")));
        }


        #endregion






    }
}
