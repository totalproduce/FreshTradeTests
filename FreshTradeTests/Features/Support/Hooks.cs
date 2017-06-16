using BoDi;
using FreshTradeTests.Libraries.Screens;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Configuration;

namespace FreshTradeTests.Features.Support
{
    [Binding]
    class Hooks
    {
        private WindowsDriver<WindowsElement> windowsDriver;
        private readonly ObjectContainer objectContainer;

        static DesiredCapabilities desiredCapabilities;
        private const string FreshTradeApp = @"C:\ProgramFilesx86\Corel\WordPerfect Office 2000\programs\pdxwin32.exe";

        private ParadoxScreen paradoxScreen;

        public Hooks(ObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability("platformName", "Windows");
            desiredCapabilities.SetCapability("deviceName", "WindowsPC");
            desiredCapabilities.SetCapability("app", FreshTradeApp);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            windowsDriver = new WindowsDriver<WindowsElement>(desiredCapabilities);
            windowsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            objectContainer.RegisterInstanceAs(windowsDriver);
            // Load Menu Form after opening Paradox
            paradoxScreen = new ParadoxScreen(this.windowsDriver);
            paradoxScreen.OpenMenuForm();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if(windowsDriver != null)
            {
                windowsDriver.Dispose();
            }
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // code that runs after the test run
        }
    }
}
