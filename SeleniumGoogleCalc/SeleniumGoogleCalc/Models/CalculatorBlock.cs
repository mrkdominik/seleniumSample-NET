using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumGoogleCalc.Common.Drivers;
using System;

namespace SeleniumGoogleCalc.PageObjectModels
{
    /// <summary>
    /// PageObjectModel for Calculator block
    /// </summary>
    public class CalculatorBlock
    {
        // Elements do not have Ids or Names, so Locator as CSS selector was best option
        private readonly IWebDriver _webDriver;

        public IWebElement Banner => _webDriver.FindElement(By.Id("zV9nZe"));
        public IWebElement Number0 => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(1) > div > div"));
        public IWebElement Number1 => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(1) > div > div"));
        public IWebElement Number2 => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(2) > div > div"));
        public IWebElement Number3 => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(3) > div > div"));
        public IWebElement Number4 => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(1) > div > div"));
        public IWebElement Number5 => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(2) > div > div"));
        public IWebElement Number6 => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(3) > div > div"));
        public IWebElement Number7 => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(1) > div > div"));
        public IWebElement Number8 => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(2) > div > div"));
        public IWebElement Number9 => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(3) > div > div"));
        public IWebElement Plus => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(4) > div > div"));
        public IWebElement Minus => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(4) > div > div"));
        public IWebElement Multiply => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(4) > div > div"));
        public IWebElement Devide => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(4) > div > div"));
        public IWebElement Equal => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(3) > div > div"));
        public IWebElement Dot => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(2) > div > div"));
        public IWebElement Percent => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(1) > td:nth-child(3) > div > div"));
        public IWebElement LeftBracket => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(1) > td:nth-child(1) > div > div"));
        public IWebElement RightBracket => _webDriver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.card-section > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(1) > td:nth-child(2) > div > div"));
        public IWebElement Result => _webDriver.FindElement(By.CssSelector("#cwos"));


        public void BannerClick()
        {
            if (Banner.Displayed)
                Banner.Click();
        }

        /// <summary>
        /// Click Equal button and return decimal result
        /// </summary>
        /// <returns></returns>
        public decimal GetDecimalResult()
        {
            Equal.Click();
            string result = Result.Text.Trim().Replace(".", ",");
            return decimal.Parse(result);
        }

        public string GetTextResult()
        {
            Equal.Click();
            return Result.Text;
        }

        /// <summary>
        /// Set driver for page block, to be able to find web elements
        /// </summary>
        /// <param name="driver"></param>
        public CalculatorBlock(IWebDriver driver) => _webDriver = driver;

        /// <summary>
        /// Foreach char in string, click to adequate element in calculator model
        /// </summary>
        /// <param name="equation">string</param>
        public void ClickWholeEquation(string equation)
        {
            //todo: filter only acceptable chars

            foreach (char character in equation.Trim())
                ClickElement(character);
        }

        private void ClickElement(char character)
        {
            // Without explicit char parsing, it should be faster.
            switch ((int)character)
            {
                case 37:
                    Percent.Click();
                    break;

                case 40:
                    LeftBracket.Click();
                    break;

                case 41:
                    RightBracket.Click();
                    break;

                case 42:
                    Multiply.Click();
                    break;

                case 43:
                    Plus.Click();
                    break;

                case 45:
                    Minus.Click();
                    break;

                case 46:
                    Dot.Click();
                    break;

                case 47:
                    Devide.Click();
                    break;

                case 48:
                    Number0.Click();
                    break;

                case 49:
                    Number1.Click();
                    break;

                case 50:
                    Number2.Click();
                    break;

                case 51:
                    Number3.Click();
                    break;

                case 52:
                    Number4.Click();
                    break;

                case 53:
                    Number5.Click();
                    break;

                case 54:
                    Number6.Click();
                    break;

                case 55:
                    Number7.Click();
                    break;

                case 56:
                    Number8.Click();
                    break;

                case 57:
                    Number9.Click();
                    break;

                case 61:
                    Equal.Click();
                    break;
            }
        }
    }
}
