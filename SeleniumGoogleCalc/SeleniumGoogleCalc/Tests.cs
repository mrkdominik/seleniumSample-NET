using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using SeleniumGoogleCalc.SeleniumHelpers;
using SeleniumGoogleCalc.PageObjectModel;


namespace SeleniumGoogleCalc
{
    [Obsolete("Will be rewritten, just for initial drivers test")]
    [TestFixture]
    public class Tests
    {
        private IWebDriver _driver;
        private readonly string url = "https://www.google.com/search?q=calculator";

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
        public void Addition()
        {
            // Arrange
            // Act
            new CalculatorPage(_driver).Addition(url);
            // Assert
        }
    }
}
