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
        private CalculatorPageModel calculatorPageModel;

        [SetUp]
        public void SetupTest()
        {
            _webDriver = new BrowserDriver(Browser.Chrome);
            _baseUrl = "https://www.google.com/search?q=calculator";

            _webDriver.Navigate().GoToUrl(_baseUrl);
            CalculatorPage calculatorPage = new CalculatorPage(_webDriver);
            calculatorPageModel = new CalculatorPageModel(calculatorPage);
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
            calculatorPageModel.Number0.Click();
            calculatorPageModel.Number1.Click();
            calculatorPageModel.Number6.Click();
            calculatorPageModel.Plus.Click();
            calculatorPageModel.Number4.Click();
            calculatorPageModel.Equal.Click();
            
            decimal result = decimal.Parse(calculatorPageModel.Result.Text.ToString());

            Assert.AreEqual(20, result);
        }

        [Test]
        public void AddZeroAndZero()
        {
            calculatorPageModel.Number0.Click();
            calculatorPageModel.Plus.Click();
            calculatorPageModel.Number0.Click();
            calculatorPageModel.Equal.Click();

            decimal result = decimal.Parse(calculatorPageModel.Result.Text.ToString());

            Assert.AreEqual(0, result);
        }

        [Test]
        public void AddMinusOneAndZero()
        {
            calculatorPageModel.Minus.Click();
            calculatorPageModel.Number1.Click();
            calculatorPageModel.Plus.Click();
            calculatorPageModel.Number0.Click();
            calculatorPageModel.Equal.Click();

            decimal result = decimal.Parse(calculatorPageModel.Result.Text.ToString());

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void AddMinusOneAndMinusOne()
        {
            calculatorPageModel.Minus.Click();
            calculatorPageModel.Number1.Click();
            calculatorPageModel.Plus.Click();
            calculatorPageModel.Minus.Click();
            calculatorPageModel.Number1.Click();
            calculatorPageModel.Equal.Click();

            decimal result = decimal.Parse(calculatorPageModel.Result.Text.ToString());

            Assert.AreEqual(-2, result);
        }

        [Test]
        public void AddZeroAndMinusOne()
        {
            calculatorPageModel.Number0.Click();
            calculatorPageModel.Plus.Click();
            calculatorPageModel.Minus.Click();
            calculatorPageModel.Number1.Click();
            calculatorPageModel.Equal.Click();

            decimal result = decimal.Parse(calculatorPageModel.Result.Text.ToString());

            Assert.AreEqual(-1, result);
        }
    }
}
