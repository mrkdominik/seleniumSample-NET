using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumGoogleCalc.SeleniumHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumGoogleCalc.PageObjectModels
{
    public class CalculatorPage
    {
        private readonly IWebDriver _driver;

        public CalculatorPage(IWebDriver driver) => _driver = driver;

        IWebElement Number0 => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(1) > div > div"));
        IWebElement Number1 => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(1) > div > div"));
        IWebElement Number2 => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(2) > div > div"));
        IWebElement Number3 => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(3) > div > div"));
        IWebElement Number4 => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(1) > div > div"));
        IWebElement Number5 => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(2) > div > div"));
        IWebElement Number6 => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(3) > div > div"));
        IWebElement Number7 => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(1) > div > div"));
        IWebElement Number8 => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(2) > div > div"));
        IWebElement Number9 => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(3) > div > div"));
        IWebElement Plus => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(4) > div > div"));
        IWebElement Minus => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(4) > div > div"));
        IWebElement Multiply => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(4) > div > div"));
        IWebElement Devide => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(4) > div > div"));
        IWebElement Equals => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(3) > div > div"));
        IWebElement Dot => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(2) > div > div"));
        IWebElement Result => _driver.FindElement(By.CssSelector("#cwmcwd > div > div > div.BRpYC > div.TIGsTb > div.fB3vD > div > div"));

        public void AdditionSixteenAndFour(string baseUrl)
        {
            _driver.Navigate().GoToUrl(baseUrl);

            Number1.Click();
            Number6.Click();
            Plus.Click();
            Number4.Click();
            Equals.Click();
        }

        public void AdditionZeroAndZero(string baseUrl)
        {
            _driver.Navigate().GoToUrl(baseUrl);

            Number0.Click();
            Plus.Click();
            Number0.Click();
            Equals.Click();
        }

        public void AdditionMinusOneAndZero(string baseUrl)
        {
            _driver.Navigate().GoToUrl(baseUrl);

            Minus.Click();
            Number1.Click();
            Plus.Click();
            Number0.Click();
            Equals.Click();
        }
        
        public void AddMinusOneAndMinusOne(string baseUrl)
        {
            _driver.Navigate().GoToUrl(baseUrl);

            Minus.Click();
            Number1.Click();
            Plus.Click();
            Minus.Click();
            Number1.Click();
            Equals.Click();
        }

        public void AddZeroAndMinusOne(string baseUrl)
        {
            _driver.Navigate().GoToUrl(baseUrl);

            Number0.Click();
            Minus.Click();
            Number1.Click();
            Equals.Click();
        }        

        public int GetResult()
        {
            if (Result != null)
                return int.Parse(Result.Text);

            return 0;
        }
    }
}
