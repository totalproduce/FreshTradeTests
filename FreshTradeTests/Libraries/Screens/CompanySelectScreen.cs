using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace FreshTradeTests.Libraries.Screens
{
    class CompanySelectScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement SelectCompanyWindow => windowsDriver.FindElementByName("Select a company");

        public CompanySelectScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void SelectTPUKFRIDAY()
        {
            SelectCompanyWindow.Click();
            SelectCompanyWindow.SendKeys(Keys.Enter);
        }

        public void SelectTPIEFRIDAY()
        {
            SelectCompanyWindow.Click();
            SelectCompanyWindow.SendKeys(Keys.Down);
            SelectCompanyWindow.SendKeys(Keys.Enter);
        }
    }
}
