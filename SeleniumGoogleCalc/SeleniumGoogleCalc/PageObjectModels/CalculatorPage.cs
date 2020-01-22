using OpenQA.Selenium;

namespace SeleniumGoogleCalc.PageObjectModels
{
    public class CalculatorPage
    {
        private readonly IWebDriver _webDriver;
        private IWebElement Number0 => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(1) > div > div"));
        private IWebElement Number1 => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(1) > div > div"));
        private IWebElement Number2 => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(2) > div > div"));
        private IWebElement Number3 => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(3) > div > div"));
        private IWebElement Number4 => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(1) > div > div"));
        private IWebElement Number5 => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(2) > div > div"));
        private IWebElement Number6 => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(3) > div > div"));
        private IWebElement Number7 => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(1) > div > div"));
        private IWebElement Number8 => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(2) > div > div"));
        private IWebElement Number9 => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(3) > div > div"));
        private IWebElement Plus => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(4) > div > div"));
        private IWebElement Minus => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(4) > td:nth-child(4) > div > div"));
        private IWebElement Multiply => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(3) > td:nth-child(4) > div > div"));
        private IWebElement Devide => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(2) > td:nth-child(4) > div > div"));
        private IWebElement Equal => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(3) > div > div"));
        private IWebElement Dot => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.SKWP2e > div > table.ElumCf > tbody > tr:nth-child(5) > td:nth-child(2) > div > div"));
        private IWebElement Result => _webDriver.FindElement(By.CssSelector("#cwmcwd > div > div > div.BRpYC > div.TIGsTb > div.fB3vD > div > div"));

        public CalculatorPage(IWebDriver driver, string baseUrl)
        {
            _webDriver = driver;
            _webDriver.Navigate().GoToUrl(baseUrl);
        }

        public decimal GetAdditionSixteenAndFour()
        {
            Number0.Click();
            Number1.Click();
            Number6.Click();
            Plus.Click();
            Number4.Click();
            Equal.Click();

            return GetResult();
        }

        public decimal GetAdditionZeroAndZero()
        {
            Number0.Click();
            Plus.Click();
            Number0.Click();
            Equal.Click();

            return GetResult();
        }

        public decimal GetAdditionMinusOneAndZero()
        {
            Minus.Click();
            Number1.Click();
            Plus.Click();
            Number0.Click();
            Equal.Click();

            return GetResult();
        }

        public decimal GetAdditionMinusOneAndMinusOne()
        {
            Minus.Click();
            Number1.Click();
            Plus.Click();
            Minus.Click();
            Number1.Click();
            Equal.Click();

            return GetResult();
        }

        public decimal GetAdditionZeroAndMinusOne()
        {
            Number0.Click();
            Minus.Click();
            Number1.Click();
            Equal.Click();

            return GetResult();
        }

        public decimal GetResult()
        {
            if (Result != null)
                return decimal.Parse(Result.Text);

            return 0;
        }
    }
}
