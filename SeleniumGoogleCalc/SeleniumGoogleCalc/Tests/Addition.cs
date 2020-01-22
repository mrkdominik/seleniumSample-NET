using System;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumGoogleCalc.SeleniumHelpers;
using SeleniumGoogleCalc.PageObjectModels;

namespace SeleniumGoogleCalc
{

    [TestFixture]
    public class Addition
    {
        private IWebDriver _webDriver;
        private string _baseUrl;

        [SetUp]
        public void SetupTest()
        {
            _webDriver = new BrowserDriver(Browser.Chrome);
            _baseUrl = "https://www.google.com/search?q=calculator";
        }

        [TearDown]
        public void AfterTestRun()
        {
            try
            {
                if (_webDriver != null)
                {
                    _webDriver.Close();
                    _webDriver.Quit();
                }
            }
            catch (Exception ex)
            {
                throw new WebDriverException("Couldn't close webDriver", ex);
            }
        }

        [Test]
        public void AddSixteenAndFour()
        {
            CalculatorPage cp = new CalculatorPage(_webDriver, _baseUrl);
            decimal result = cp.GetAdditionSixteenAndFour();

            Assert.AreEqual(20, result);
        }

        [Test]
        public void AddZeroAndZero()
        {
            CalculatorPage cp = new CalculatorPage(_webDriver, _baseUrl);
            decimal result = cp.GetAdditionZeroAndZero();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void AddMinusOneAndZero()
        {
            CalculatorPage cp = new CalculatorPage(_webDriver, _baseUrl);
            decimal result = cp.GetAdditionMinusOneAndZero();

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void AddMinusOneAndMinusOne()
        {
            CalculatorPage cp = new CalculatorPage(_webDriver, _baseUrl);
            decimal result = cp.GetAdditionMinusOneAndMinusOne();

            Assert.AreEqual(-2, result);
        }

        [Test]
        public void AddZeroAndMinusOne()
        {
            CalculatorPage cp = new CalculatorPage(_webDriver, _baseUrl);
            decimal result = cp.GetAdditionZeroAndMinusOne();

            Assert.AreEqual(-1, result);
        }
    }
}
