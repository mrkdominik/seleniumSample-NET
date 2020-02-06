using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumGoogleCalc.Common.Drivers;
using SeleniumGoogleCalc.Common.Enums;
using SeleniumGoogleCalc.PageObjectModels;

namespace SeleniumGoogleCalc.Tests
{
    // Class should be abstract, but NUnit do not recognize TestFixture.
    [TestFixture(Browser.Chrome)]
    //[TestFixture(Browser.Edge)] // Edge webdriver is still from MS as singleton. so it can't run parallelly in scope, only serially.
    //[TestFixture(Browser.Ie)] // IE is soo obsolete, that it runs, but in comparsion is 10x slower
    [Parallelizable(ParallelScope.Fixtures)]
    public class TestBase
    {
        protected readonly Browser BrowserB;
        protected IWebDriver Driver;
        protected CalculatorBlock CalculatorBlock;

        protected TestBase(Browser browser)
        {
            BrowserB = browser;
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {   
            Driver = DriverFactory.CreateInstanceDesktop(BrowserB);
            //_driver = DriverFactory.CreateInstanceBrowserStack(_browser);

            Driver.Navigate().GoToUrl(new Uri("https://www.google.com/search?q=calculator"));
            Driver.Manage().Window.Maximize();
            CalculatorBlock = new CalculatorBlock(Driver);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.Quit();
            Driver.Dispose();
            Driver = null;
        }

        [SetUp]
        public void SetUp()
        {

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Navigate().Refresh();
        }

    }
}
