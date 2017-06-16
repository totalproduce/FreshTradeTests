using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace FreshTradeTests.Libraries.Screens
{
    class MenuScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement FileMenu => windowsDriver.FindElementByName("File");
        private WindowsElement ExitMenuOption => windowsDriver.FindElementByName("Exit");

        public MenuScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public bool IsLoaded()
        {
           return false;
        }

        public void CloseFreshTrade()
        {
            FileMenu.Click();
            ExitMenuOption.Click();
        }
    }
}
