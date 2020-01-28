using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using SeleniumGoogleCalc.Models;
using SeleniumToolkit.Common.Drivers;

namespace SeleniumGoogleCalc.Tests
{
    [TestFixture(PlatformType.Android, "6")]
    [TestFixture(PlatformType.Android, "4.4.2")]
    [Parallelizable(ParallelScope.Fixtures)]
    public class AdditionAndroid
    {
        readonly IWebDriver _webDriver;

        CalculatorBlockAndroid calculatorBlockAndroid;

        public AdditionAndroid(PlatformType platform, string osVersion)
        {
            _webDriver = DriverFactory.CreateInstanceMobile(platform, osVersion);
        }

        [SetUp]
        public void PrepareElements()
        {
            _webDriver.Navigate().GoToUrl(new Uri("https://www.google.com/search?q=calculator"));
            _webDriver.Manage().Window.Maximize();

            calculatorBlockAndroid = new CalculatorBlockAndroid(_webDriver);
        }

        [Test()]
        public void TestShouldFindElementsById()
        {
            ICollection<AndroidElement> elements = _webDriver.FindElements(By.Id("android:id/action_bar_container")) as ICollection<AndroidElement>;
            if (elements == null)
                throw new ArgumentNullException(nameof(elements));

            Assert.AreEqual(1, elements.Count);
        }

        [Test()]
        public void TestShouldFindElementsByClassName()
        {
            ICollection<AndroidElement> elements = _webDriver.FindElements(By.CssSelector("android.widget.FrameLayout")) as ICollection<AndroidElement>;
            if (elements == null)
                throw new ArgumentNullException(nameof(elements));

            Assert.AreEqual(3, elements.Count);
        }
    }
}
