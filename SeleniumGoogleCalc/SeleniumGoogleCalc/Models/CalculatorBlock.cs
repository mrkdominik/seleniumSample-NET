using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumGoogleCalc.Common;

namespace SeleniumGoogleCalc.PageObjectModels
{
    /// <summary>
    /// PageObjectModel for Calculator block
    /// </summary>
    public class CalculatorBlock
    {
        private readonly IWebDriver webDriver;
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

        /// <summary>
        /// Set driver for page blok, to be able to find web elements
        /// </summary>
        /// <param name="driver"></param>
        public CalculatorBlock(IWebDriver driver)
        {
            webDriver = driver;
        }
    }
}
