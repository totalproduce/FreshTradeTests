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

namespace FreshTradeTests.Features.Support
{
    [Binding]
    class Hooks
    {
        private readonly ObjectContainer objectContainer;
        private IWebDriver driver;
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
            Dictionary<string, object> caps = new Dictionary<string, object>();
            caps.Add("platformName","Windows");
            caps.Add("deviceName", "WindowsPC");
            caps.Add("app", FreshTradeApp);

            desiredCapabilities = new DesiredCapabilities(caps);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new WindowsDriver<WindowsElement>(desiredCapabilities);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            objectContainer.RegisterInstanceAs(driver);
            // Load the menu forn after opening Paradox
            paradoxScreen = new ParadoxScreen(this.driver);
            paradoxScreen.OpenMenuForm();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if(driver != null)
            {
                driver.Dispose();
            }
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // code that runs after the test run
        }
    }
}
