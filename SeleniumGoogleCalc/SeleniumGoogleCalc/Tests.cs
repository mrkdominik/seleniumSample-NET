using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace SeleniumGoogleCalc
{
    [Obsolete("will be rewritten, just for initial drivers test")]
    [TestFixture]
    public class Tests
    {
        private IWebDriver _driver;
        private IWebDriver _driver2;

        [SetUp]
        public void SetupTest()
        {
            _driver = new ChromeDriver();
            _driver2 = new InternetExplorerDriver(AppDomain.CurrentDomain.BaseDirectory, new InternetExplorerOptions(), TimeSpan.FromMinutes(5));
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

        [Test]
        public void OpenPageIE()
        {
            // Arrange
            // Act
            string url = "https://www.google.com/search?q=calculator";
            _driver2.Navigate().GoToUrl(url);
            // Assert
        }
    }
}
