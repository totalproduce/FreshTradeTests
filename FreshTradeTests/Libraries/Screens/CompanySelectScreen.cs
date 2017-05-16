using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Support.PageObjects;

namespace FreshTradeTests.Libraries.Screens
{
    class CompanySelectScreen
    {
        private readonly IWebDriver driver;

        public CompanySelectScreen(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        // Locators
        [FindsBy(How = How.Name, Using = "Select a company")]
        private IWebElement selectCompanyWindow;

        public void SelectTPUKFRIDAY()
        {
            selectCompanyWindow.Click();
            selectCompanyWindow.SendKeys(Keys.Enter);
        }

        public void SelectTPIEFRIDAY()
        {
            selectCompanyWindow.Click();
            selectCompanyWindow.SendKeys(Keys.Down);
            selectCompanyWindow.SendKeys(Keys.Enter);
        }
    }
}
