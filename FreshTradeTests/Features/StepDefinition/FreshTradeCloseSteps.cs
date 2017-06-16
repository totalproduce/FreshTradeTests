using FreshTradeTests.Libraries.Screens;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace FreshTradeTests.Features.StepDefinition
{
    [Binding]
    public class FreshTradeCloseSteps
    {
        private WindowsDriver<WindowsElement> windowsDriver;
        
        private CompanySelectScreen companySelectionScreen;
        private MenuScreen menuScreen;

        public FreshTradeCloseSteps(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        [Given(@"I select TPUKFRIDAY")]
        public void GivenISelectTPUKFRIDAY()
        {
            companySelectionScreen = new CompanySelectScreen(this.windowsDriver);
            companySelectionScreen.SelectTPUKFRIDAY();
        }

        [Given(@"I select TPIEFRIDAY")]
        public void GivenISelectTPIEFRIDAY()
        {
            companySelectionScreen = new CompanySelectScreen(this.windowsDriver);
            companySelectionScreen.SelectTPIEFRIDAY();
        }

        [When(@"I close FreshTrade from the menu")]
        public void WhenICloseFromTheMenu()
        {
            menuScreen = new MenuScreen(this.windowsDriver);
            menuScreen.CloseFreshTrade();
        }
        
        [Then(@"FreshTrade should be closed")]
        public void ThenFreshTradeShouldBeClosed()
        {
            Assert.IsFalse(menuScreen.IsLoaded());
        }
    }
}
