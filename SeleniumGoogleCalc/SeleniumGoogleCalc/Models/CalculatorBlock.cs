using OpenQA.Selenium;
using System;

namespace SeleniumGoogleCalc.PageObjectModels
{
    /// <summary>
    /// PageObjectModel for Calculator block
    /// </summary>
}
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
    /// Click Equal button and return decimal result
    /// </summary>
    /// <returns></returns>
    public decimal GetResult()
    {
        Equal.Click();
        return decimal.Parse(Result.Text);
    }

    /// <summary>
    /// Set driver for page blok, to be able to find web elements
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

        foreach (char button in equation)
            ClickElement(button);
    }

    private void ClickElement(char button)
    {
        if (button == char.Parse("0"))
            Number0.Click();

        else if (button == char.Parse("1"))
            Number1.Click();

        else if (button == char.Parse("2"))
            Number2.Click();

        else if (button == char.Parse("3"))
            Number3.Click();

        else if (button == char.Parse("4"))
            Number4.Click();

        else if (button == char.Parse("5"))
            Number5.Click();

        else if (button == char.Parse("6"))
            Number6.Click();

        else if (button == char.Parse("7"))
            Number7.Click();

        else if (button == char.Parse("8"))
            Number8.Click();

        else if (button == char.Parse("9"))
            Number9.Click();

        else if (button == char.Parse("+"))
            Plus.Click();

        else if (button == char.Parse("-"))
            Minus.Click();

        else if (button == char.Parse("/"))
            Devide.Click();

        else if (button == char.Parse("="))
            Equal.Click();

        else if (button == char.Parse("."))
            Dot.Click();
    }
}
