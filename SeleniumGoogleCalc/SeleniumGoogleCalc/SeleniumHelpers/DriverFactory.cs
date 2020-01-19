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
        private IWebDriver _webDriver;
        public Browser _browser;

        public void Initialize()
        {
            if (Browser.Chrome == _browser)
            {
                _webDriver = new ChromeDriver();
            }
            else if (Browser.IE == _browser)
            {
                _webDriver = new InternetExplorerDriver();
            }
            else
            {
                _webDriver = new FirefoxDriver();
            }
        }

        public IWebDriver GetInstance(Browser browser)
        {
            if (_webDriver == null)
            {
                _browser = browser;
                Initialize();
            }

            return _webDriver;
        }
    }
}
