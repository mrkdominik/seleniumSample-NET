using System;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumGoogleCalc.Common;
using SeleniumGoogleCalc.Common.Drivers;
using SeleniumGoogleCalc.Common.Enums;
using SeleniumGoogleCalc.PageObjectModels;

namespace SeleniumGoogleCalc.Tests
{
    //[TestFixture(Browser.Chrome)]
    [TestFixture(Browser.Chrome)]
    [TestFixture(Browser.Edge)]
    [Parallelizable(ParallelScope.Fixtures)]
    public class Addition
    {
        private IWebDriver _driver;
        private readonly Browser _browser;
        private CalculatorBlock _calculatorBlock;

        public Addition(Browser browser)
        {
            _browser = browser;
        }

        [OneTimeSetUp]
        public void PrepareElements()
        {
            _driver = DriverFactory.CreateInstanceDesktop(_browser);
            //_driver = DriverFactory.CreateInstanceBrowserStack(_browser);

            _driver.Navigate().GoToUrl(new Uri("https://www.google.com/search?q=calculator"));
            _driver.Manage().Window.Maximize();
            _calculatorBlock = new CalculatorBlock(_driver);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }

        [SetUp]
        public void SetUps()
        {

        }

        [TearDown]
        public void TearDown()
        {
            _driver.Navigate().Refresh();
        }

        [Test]
        public void AddSixteenAndFour()
        {
            _calculatorBlock.ClickWholeEquation("16+4");
            Assert.AreEqual(20, _calculatorBlock.GetResult());
        }

        [Test]
        public void AddZeroAndZero()
        {
            _calculatorBlock.ClickWholeEquation("0+0");
            Assert.AreEqual(0, _calculatorBlock.GetResult());
        }

        [Test]
        public void AddMinusOneAndZero()
        {
            _calculatorBlock.ClickWholeEquation("-1+0");
            Assert.AreEqual(-1, _calculatorBlock.GetResult());
        }

        [Test]
        public void AddMinusOneAndMinusOne()
        {
            _calculatorBlock.ClickWholeEquation("-1+-1");
            Assert.AreEqual(-2, _calculatorBlock.GetResult());
        }

        [Test]
        public void AddZeroAndMinusOne()
        {
            _calculatorBlock.ClickWholeEquation("0+-1");
            Assert.AreEqual(-1, _calculatorBlock.GetResult());
        }
    }
}
