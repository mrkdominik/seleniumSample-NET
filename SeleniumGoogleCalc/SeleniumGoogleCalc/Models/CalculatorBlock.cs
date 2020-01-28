using OpenQA.Selenium;

namespace SeleniumGoogleCalc.Models
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
        /// Click Equal character and return decimal result
        /// </summary>
        /// <returns></returns>
        public decimal GetResult()
        {
            Equal.Click();
            return decimal.Parse(Result.Text);
        }

        /// <summary>
        /// Set driver for page block, to be able to find web elements
        /// </summary>
        /// <param name="driver"></param>
        public CalculatorBlock(IWebDriver driver)
        {
            webDriver = driver;
        }

        /// <summary>
        /// Foreach char in string, click to adequate element in calculator model
        /// </summary>
        /// <param name="equation">string</param>
        public void ClickWholeEquation(string equation)
        {
            //todo: filter only acceptable chars

            equation.Trim();

            foreach (char character in equation)
                ClickElement(character);
        }

        private void ClickElement(char character)
        {
            switch ((int)character)
            {
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

                case 43:
                    Plus.Click();
                    break;

                case 45:
                    Minus.Click();
                    break;

                case 47:
                    Devide.Click();
                    break;

                case 61:
                    Equal.Click();
                    break;

                case 46:
                    Dot.Click();
                    break;
            }



        }
    }
}
