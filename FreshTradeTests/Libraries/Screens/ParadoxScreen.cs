using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.PageObjects;
using System;

namespace FreshTradeTests.Libraries.Screens
{
    class ParadoxScreen
    {
        private WindowsDriver<WindowsElement> windowsDriver;

        private WindowsElement FileMenu => windowsDriver.FindElementByName("File");
        private WindowsElement OpenMenuOption => windowsDriver.FindElementByName("Open");
        private WindowsElement FormMenuOption => windowsDriver.FindElementByName("Form...");
        private WindowsElement MenuForm => windowsDriver.FindElementByName("Menu.fdl");

        public ParadoxScreen(WindowsDriver<WindowsElement> windowsDriver)
        {
            this.windowsDriver = windowsDriver;
        }

        public void OpenMenuForm()
        {
            FileMenu.Click();
            OpenMenuOption.Click();
            FormMenuOption.Click();
            MenuForm.Click();
            MenuForm.SendKeys(Keys.Enter);
        }
    }
}
