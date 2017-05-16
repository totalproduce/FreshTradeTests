using FreshTradeTests.Libraries.Screens;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace FreshTradeTests.Features.StepDefinition
{
    [Binding]
    public class FreshTradeCloseSteps
    {
        private readonly IWebDriver driver;
        private CompanySelectScreen companySelectionScreen;
        private MenuScreen menuScreen;

        public FreshTradeCloseSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I select TPUKFRIDAY")]
        public void GivenISelectTPUKFRIDAY()
        {
            companySelectionScreen = new CompanySelectScreen(this.driver);
            companySelectionScreen.SelectTPUKFRIDAY();
        }

        [Given(@"I select TPIEFRIDAY")]
        public void GivenISelectTPIEFRIDAY()
        {
            companySelectionScreen = new CompanySelectScreen(this.driver);
            companySelectionScreen.SelectTPIEFRIDAY();
        }

        [When(@"I close FreshTrade from the menu")]
        public void WhenICloseFromTheMenu()
        {
            menuScreen = new MenuScreen(this.driver);
            menuScreen.CloseFreshTrade();
        }
        
        [Then(@"FreshTrade should be closed")]
        public void ThenFreshTradeShouldBeClosed()
        {
            Assert.IsFalse(menuScreen.IsLoaded());
        }
    }
}
