using NUnit.Framework;
using SeleniumGoogleCalc.Common;
using SeleniumGoogleCalc.PageObjectModels;
using System;

namespace SeleniumGoogleCalc.Tests
{
    [TestFixture(Profile.Local, Browser.Chrome)]
    [TestFixture(Profile.Local, Browser.IE)]
    [Parallelizable(ParallelScope.Fixtures)]
    public class Addition : DriverFactory
    {
        public Addition(Profile profile, Browser browser) : base(profile, browser) { }

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
            calculatorBlock.ClickWholeEquation("16+4");
            Assert.AreEqual(20, calculatorBlock.GetResult());
        }

        [Test]
        public void AddZeroAndZero()
        {
            calculatorBlock.ClickWholeEquation("0+0");
            Assert.AreEqual(0, calculatorBlock.GetResult());
        }

        [Test]
        public void AddMinusOneAndZero()
        {
            calculatorBlock.ClickWholeEquation("-1+0");
            Assert.AreEqual(-1, calculatorBlock.GetResult());
        }

        [Test]
        public void AddMinusOneAndMinusOne()
        {
            calculatorBlock.ClickWholeEquation("-1+-1");
            Assert.AreEqual(-2, calculatorBlock.GetResult());
        }

        [Test]
        public void AddZeroAndMinusOne()
        {
            calculatorBlock.ClickWholeEquation("0+-1");
            Assert.AreEqual(-1, calculatorBlock.GetResult());
        }
    }
}
