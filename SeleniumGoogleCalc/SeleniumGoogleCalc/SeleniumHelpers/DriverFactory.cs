using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumGoogleCalc.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumGoogleCalc.SeleniumHelpers
{
    class DriverFactory
    {
        public IWebDriver CreateInstance(Browser browser)
        {
            if (Browser.Chrome == browser)
            {
                return new ChromeDriver();
            }
            else if (Browser.IE == browser)
            {
                return new InternetExplorerDriver();
            }
            else
            {
                return new FirefoxDriver();
            }
        }
    }
}
