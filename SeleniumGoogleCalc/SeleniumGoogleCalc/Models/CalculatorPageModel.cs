using OpenQA.Selenium;
using SeleniumGoogleCalc.SeleniumHelpers;

namespace SeleniumGoogleCalc.PageObjectModels
{
    public class CalculatorPageModel
    {
        public IWebDriver webDriver { get; set; }
        public IWebElement Number0 { get; set; }
        public IWebElement Number1 { get; set; }
        public IWebElement Number2 { get; set; }
        public IWebElement Number3 { get; set; }
        public IWebElement Number4 { get; set; }
        public IWebElement Number5 { get; set; }
        public IWebElement Number6 { get; set; }
        public IWebElement Number7 { get; set; }
        public IWebElement Number8 { get; set; }
        public IWebElement Number9 { get; set; }
        public IWebElement Plus { get; set; }
        public IWebElement Minus { get; set; }
        public IWebElement Multiply { get; set; }
        public IWebElement Devide { get; set; }
        public IWebElement Equal { get; set; }
        public IWebElement Dot { get; set; }
        public IWebElement Result { get; set; }

        public CalculatorPageModel(CalculatorPage calculatorPage)
        {           
            if (calculatorPage != null)
                SetCalculatorPage(calculatorPage);
        }

        public void SetCalculatorPage(CalculatorPage calculatorPage)
        {
            Number0 = calculatorPage.Number0;
            Number1 = calculatorPage.Number1;
            Number2 = calculatorPage.Number2;
            Number3 = calculatorPage.Number3;
            Number4 = calculatorPage.Number4;
            Number5 = calculatorPage.Number5;
            Number6 = calculatorPage.Number6;
            Number7 = calculatorPage.Number7;
            Number8 = calculatorPage.Number8;
            Number9 = calculatorPage.Number9;
            Plus = calculatorPage.Plus;
            Minus = calculatorPage.Minus;
            Multiply = calculatorPage.Multiply;
            Devide = calculatorPage.Devide;
            Equal = calculatorPage.Equal;
            Result = calculatorPage.Result;
        }

        public CalculatorPage GetCalculatorPage()
        {
            CalculatorPage calculatorPage = new CalculatorPage();
            Number0 = calculatorPage.Number0;
            Number1 = calculatorPage.Number0;
            Number2 = calculatorPage.Number0;
            Number3 = calculatorPage.Number0;
            Number4 = calculatorPage.Number0;
            Number5 = calculatorPage.Number0;   
            Number6 = calculatorPage.Number0;
            Number7 = calculatorPage.Number0;
            Number8 = calculatorPage.Number0;
            Number9 = calculatorPage.Number0;
            Plus = calculatorPage.Plus;
            Minus = calculatorPage.Minus;
            Multiply = calculatorPage.Multiply;
            Devide = calculatorPage.Devide;
            Equal = calculatorPage.Equal;
            Result = calculatorPage.Result;

            return calculatorPage;
        }
    }
}
