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
    public class Addition : TestBase
    {
        public Addition(Browser browser) : base(browser) { }

        [Test]
        public void AddZeroAndZero()
        {
            CalculatorBlock.ClickWholeEquation("0+0");
            Assert.AreEqual(0, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void AddZeroAndOne()
        {
            CalculatorBlock.ClickWholeEquation("0+1");
            Assert.AreEqual(1, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void AddOneAndZero()
        {
            CalculatorBlock.ClickWholeEquation("1+0");
            Assert.AreEqual(1, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void AddAscendRangeAndDescendRange()
        {
            //Google calc is capped only to 9 numbers, but correct are both results
            CalculatorBlock.ClickWholeEquation("0123456789+9876543210");

            decimal result = CalculatorBlock.GetDecimalResult();
            Assert.AreEqual(true, result == 1111111110 || result == 9999999999);
        }

        [Test]
        public void AddBracketsFiveAndTwo()
        {
            CalculatorBlock.ClickWholeEquation("(+5)+(+2)");
            Assert.AreEqual(7, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void AddDecimalTwoPointTwoMinusOne()
        {           
            CalculatorBlock.ClickWholeEquation("2.2+1");
            Assert.AreEqual("3.2", CalculatorBlock.GetTextResult());
        }

        [Test]
        public void AddHundredAndTwentyFivePercent()
        {
            CalculatorBlock.ClickWholeEquation("100+25%");
            Assert.AreEqual(125, CalculatorBlock.GetDecimalResult());
        }
    }
}
