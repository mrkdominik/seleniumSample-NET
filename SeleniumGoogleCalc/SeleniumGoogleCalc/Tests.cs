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
        private IWebDriver _webDriver;
        private string _baseUrl;

        [SetUp]
        public void SetupTest()
        {
            _webDriver = new DriverFactory().GetInstance(Browser.Chrome);
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
                throw new ArgumentNullException("webDriver can not be reset properly", ex);
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
