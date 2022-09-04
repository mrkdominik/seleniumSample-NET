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
    public class Multiplication : TestBase
    {
        public Multiplication(Browser browser) : base(browser) { }

        [Test]
        public void MulZeroAndZero()
        {
            CalculatorBlock.ClickWholeEquation("0*0");
            Assert.AreEqual(0, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void MulZeroAndOne()
        {
            CalculatorBlock.ClickWholeEquation("0*1");
            Assert.AreEqual(0, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void MulOneAndZero()
        {
            CalculatorBlock.ClickWholeEquation("1*0");
            Assert.AreEqual(0, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void MulTenAndTwo()
        {
            CalculatorBlock.ClickWholeEquation("10*2");
            Assert.AreEqual(20, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void MulMinusTenAndTwo()
        {
            CalculatorBlock.ClickWholeEquation("-10*2");
            Assert.AreEqual(-20, CalculatorBlock.GetDecimalResult());
        }

        [Test]
        public void MulDecimalTwoPointTwoAndTwo()
        {
            CalculatorBlock.ClickWholeEquation("2.2*2");
            Assert.AreEqual(4.4, CalculatorBlock.GetDecimalResult());
        }
        [Test]
        public void MulHundredAndTwentyFivePercent()
        {
            CalculatorBlock.ClickWholeEquation("100*25%");
            Assert.AreEqual(25, CalculatorBlock.GetDecimalResult());
        }
    }
}
