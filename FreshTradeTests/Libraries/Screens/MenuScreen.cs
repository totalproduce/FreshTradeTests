using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Support.PageObjects;

namespace FreshTradeTests.Libraries.Screens
{
    class MenuScreen
    {
        private readonly IWebDriver driver;

        public MenuScreen(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        // Locators - MENU
        [FindsBy(How = How.Name, Using = "File")]
        private IWebElement fileMenu;
        // Locators - FILE/
        [FindsBy(How = How.Name, Using = "Open")]
        private IWebElement openMenu;
        [FindsBy(How = How.Name, Using = "Exit")]
        private IWebElement exitMenu;
        // Locators - File/Open/
        [FindsBy(How = How.Name, Using = "Form...")]
        private IWebElement formMenu;
        // Locators - File/Open/OpenPopupWindow
        [FindsBy(How = How.Name, Using = "Menu.fdl")]
        private IWebElement formFileName;
        [FindsBy(How = How.Name, Using = "Open")]
        private IWebElement openButton;

        public bool IsLoaded()
        {
            return false; // TODO - Add the check if the menu fileMenu element is displayed
        }

        public void OpenMenuForm()
        {
            fileMenu.Click();
            openMenu.Click();
            formMenu.Click();
            formFileName.Click();
            formFileName.SendKeys(Keys.Enter);
        }
        public void CloseFreshTrade()
        {
            fileMenu.Click();
            exitMenu.Click();
        }
    }
}
