using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using SeleniumGoogleCalc.SeleniumHelpers;
using SeleniumGoogleCalc.PageObjectModels;
using SeleniumGoogleCalc.Enums;

namespace SeleniumGoogleCalc
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver _driver;
        private Browser _browser;
        private string _baseUrl;

        [SetUp]
        public void SetupTest()
        {
            _driver = new DriverFactory().CreateInstance(_browser);
            _browser = Browser.Chrome;
            _baseUrl = "https://www.google.com/search?q=calculator";
        }

        [TearDown]
        public void AfterTestRun()
        {
            try
            {
                if (_driver != null)
                {
                    _driver.Close();
                    _driver.Quit();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("webDriver can not be reset properly", ex);
            }
        }

        [Test]
        public void AddSixteenAndFour()
        {
            // Arrange
            // Act
            new CalculatorPage(_driver).AdditionSixteenAndFour(_baseUrl);
            int result = new CalculatorPage(_driver).GetResult();

            // Assert
            Assert.AreEqual(20, result);
        }

        [Test]
        public void AddZeroAndZero()
        {
            // Arrange
            // Act
            new CalculatorPage(_driver).AdditionZeroAndZero(_baseUrl);
            int result = new CalculatorPage(_driver).GetResult();

            // Assert
            Assert.AreEqual(0, result);
        }


        [Test]
        public void AddMinusOneAndZero()
        {
            // Arrange
            // Act
            new CalculatorPage(_driver).AdditionMinusOneAndZero(_baseUrl);
            int result = new CalculatorPage(_driver).GetResult();

            // Assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void AddMinusOneAndMinusOne()
        {
            // Arrange
            // Act
            new CalculatorPage(_driver).AddMinusOneAndMinusOne(_baseUrl);
            int result = new CalculatorPage(_driver).GetResult();

            // Assert
            Assert.AreEqual(-2, result);
        }

        [Test]
        public void AddZeroAndMinusOne()
        {
            // Arrange
            // Act
            new CalculatorPage(_driver).AddZeroAndMinusOne(_baseUrl);
            int result = new CalculatorPage(_driver).GetResult();

            // Assert
            Assert.AreEqual(-1, result);
        }
    }
}
