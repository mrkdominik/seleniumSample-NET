using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using SeleniumGoogleCalc.SeleniumHelpers;

namespace SeleniumGoogleCalc
{
    [Obsolete("Will be rewritten, just for initial drivers test")]
    [TestFixture]
    public class Tests
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetupTest()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void AfterTestRun()
        {
            new SeleniumHelper(_driver).ResetDriver();            
        }

        [Test]
        public void OpenPageChrome()
        {
            // Arrange
            // Act
            string url = "https://www.google.com/search?q=calculator";
            _driver.Navigate().GoToUrl(url);
            // Assert
        }
    }
}
