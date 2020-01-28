using OpenQA.Selenium;

namespace SeleniumGoogleCalc.Models
{
    /// <summary>
    /// PageObjectModel for Calculator block
    /// </summary>
    public class CalculatorBlockAndroid
    {
        private readonly IWebDriver webDriver;
        public IWebElement Number0 => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Number1 => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Number2 => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Number3 => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Number4 => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Number5 => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Number6 => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Number7 => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Number8 => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Number9 => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Plus => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Minus => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Multiply => webDriver.FindElement(By.CssSelector("#"));
        public IWebElement Devide => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Equal => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Dot => webDriver.FindElement(By.CssSelector(""));
        public IWebElement Result => webDriver.FindElement(By.CssSelector(""));
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
        public CalculatorBlockAndroid(IWebDriver driver)
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
