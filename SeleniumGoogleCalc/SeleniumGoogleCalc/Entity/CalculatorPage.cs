using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumGoogleCalc.SeleniumHelpers
{
    public class CalculatorPage
    {
        private IWebDriver webDriver;

        public CalculatorPage() { }

        public CalculatorPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement Number0 => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(1) > div > div"));
        public IWebElement Number1 => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(1) > div > div"));
        public IWebElement Number2 => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(2) > div > div"));
        public IWebElement Number3 => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(3) > div > div"));
        public IWebElement Number4 => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(1) > div > div"));
        public IWebElement Number5 => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(2) > div > div"));
        public IWebElement Number6 => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(3) > div > div"));
        public IWebElement Number7 => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(1) > div > div"));
        public IWebElement Number8 => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(2) > div > div"));
        public IWebElement Number9 => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(3) > div > div"));
        public IWebElement Plus => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(4) > div > div"));
        public IWebElement Minus => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(4) > div > div"));
        public IWebElement Multiply => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(4) > div > div"));
        public IWebElement Devide => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(4) > div > div"));
        public IWebElement Equal => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(3) > div > div"));
        public IWebElement Dot => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(2) > div > div"));
        public IWebElement Result => webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.BRpYC > div.TIGsTb > div.fB3vD > div > div"));
    }
}