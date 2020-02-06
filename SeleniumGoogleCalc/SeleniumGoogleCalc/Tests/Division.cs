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
    public class Division : TestBase
    {
        public Division(Browser browser) : base(browser) { }

        [Test]
        public void DivZeroAndZero()
        {
            CalculatorBlock.ClickWholeEquation("0/0");
            Assert.AreEqual("Error", CalculatorBlock.GetTextResult());
        }

        [Test]
        public void DivOneAndZero()
        {
            CalculatorBlock.ClickWholeEquation("1/0");
            Assert.AreEqual("Infinity", CalculatorBlock.GetTextResult());
        }

        [Test]
        public void DivZeroAndOne()
        {
            CalculatorBlock.ClickWholeEquation("0/1");
            Assert.AreEqual(0, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void DivTenAndTwo()
        {
            CalculatorBlock.ClickWholeEquation("10/2");
            Assert.AreEqual(5, CalculatorBlock.GetDecimalResult());

        }

        [Test]
        public void DivMinusTenAndTwo()
        {
            CalculatorBlock.ClickWholeEquation("-10/2");
            Assert.AreEqual(-5, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void DivBracketsFiveAndTwo()
        {
            CalculatorBlock.ClickWholeEquation("(+5)+(+2)");
            Assert.AreEqual(7, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void DivDecimalTwoPointTwoAndTwo()
        {
            CalculatorBlock.ClickWholeEquation("2.2/2");
            Assert.AreEqual(1.1, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void AddHundredAndTwentyFivePercent()
        {
            CalculatorBlock.ClickWholeEquation("100/25%");
            Assert.AreEqual(400, CalculatorBlock.GetDecimalResult());
        }
    }
}
