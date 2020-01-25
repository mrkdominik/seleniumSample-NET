using System;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumGoogleCalc.Common;
using SeleniumGoogleCalc.PageObjectModels;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;

namespace SeleniumGoogleCalc.Tests
{

    [TestFixture(Profile.Local, Browser.Chrome)]
    [TestFixture(Profile.Local, Browser.IE)]    
    [Parallelizable(ParallelScope.Fixtures)]
    public class Addition : DriverFactory
    {
        public Addition(Profile profile, Browser environment) : base(profile, environment) { }

        private CalculatorBlock calculatorBlock;

        [SetUp]
        public void PrepareElements()
        {
            driver.Navigate().GoToUrl(new Uri("https://www.google.com/search?q=calculator"));
            driver.Manage().Window.Maximize();
            calculatorBlock = new CalculatorBlock(driver);
        }

        [Test]
        public void AddSixteenAndFour()
        {
            calculatorBlock.Number0.Click();
            calculatorBlock.Number1.Click();
            calculatorBlock.Number6.Click();
            calculatorBlock.Plus.Click();
            calculatorBlock.Number4.Click();
            calculatorBlock.Equal.Click();

            decimal result = decimal.Parse(calculatorBlock.Result.Text.ToString());

            Assert.AreEqual(20, result);
        }


        [Test]
        public void AddZeroAndZero()
        {
            calculatorBlock.Number0.Click();
            calculatorBlock.Plus.Click();
            calculatorBlock.Number0.Click();
            calculatorBlock.Equal.Click();

            decimal result = decimal.Parse(calculatorBlock.Result.Text.ToString());

            Assert.AreEqual(0, result);
        }

        [Test]
        public void AddMinusOneAndZero()
        {
            calculatorBlock.Minus.Click();
            calculatorBlock.Number1.Click();
            calculatorBlock.Plus.Click();
            calculatorBlock.Number0.Click();
            calculatorBlock.Equal.Click();

            decimal result = decimal.Parse(calculatorBlock.Result.Text.ToString());

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void AddMinusOneAndMinusOne()
        {
            calculatorBlock.Minus.Click();
            calculatorBlock.Number1.Click();
            calculatorBlock.Plus.Click();
            calculatorBlock.Minus.Click();
            calculatorBlock.Number1.Click();
            calculatorBlock.Equal.Click();

            decimal result = decimal.Parse(calculatorBlock.Result.Text.ToString());

            Assert.AreEqual(-2, result);
        }

        [Test]
        public void AddZeroAndMinusOne()
        {
            calculatorBlock.Number0.Click();
            calculatorBlock.Plus.Click();
            calculatorBlock.Minus.Click();
            calculatorBlock.Number1.Click();
            calculatorBlock.Equal.Click();

            decimal result = decimal.Parse(calculatorBlock.Result.Text.ToString());

            Assert.AreEqual(-1, result);
        }
    }
}
