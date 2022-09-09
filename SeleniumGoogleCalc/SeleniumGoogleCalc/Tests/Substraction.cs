using System;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumGoogleCalc.Common;
using SeleniumGoogleCalc.Common.Drivers;
using SeleniumGoogleCalc.Common.Enums;
using SeleniumGoogleCalc.PageObjectModels;

namespace SeleniumGoogleCalc.Tests
{
    public class Substraction : TestBase
    {
        public Substraction(Browser browser) : base(browser) { }

        [Test]
        public void SubZeroMinusZero()
        {
            CalculatorBlock.ClickWholeEquation("0-0");
            Assert.AreEqual(0, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void SubMinusOneAndMinusZero()
        {
            CalculatorBlock.ClickWholeEquation("-1-0");
            Assert.AreEqual(-1, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void SubZeroAndMinusOne()
        {
            CalculatorBlock.ClickWholeEquation("0-1");
            Assert.AreEqual(-1, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void SubDescendantRangeAndAscendantRange()
        {
            CalculatorBlock.ClickWholeEquation("9876543210-0123456789");

            decimal result = CalculatorBlock.GetDecimalResult();
            Assert.AreEqual(true, result == 9753086421);
        }

        [Test]
        public void SubBracketsFiveMinusTwo()
        {
            CalculatorBlock.ClickWholeEquation("(-5)-(-2)");
            Assert.AreEqual(-3, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void SubDecimalTwoPointTwoMinusOne()
        {
            CalculatorBlock.ClickWholeEquation("2.2-1");
            Assert.AreEqual("1.2", CalculatorBlock.GetTextResult());
        }

        [Test]
        public void SubHundredAndTwentyFivePercent()
        {
            CalculatorBlock.ClickWholeEquation("100-25%");
            Assert.AreEqual(75, CalculatorBlock.GetDecimalResult());
        }
    }
}
