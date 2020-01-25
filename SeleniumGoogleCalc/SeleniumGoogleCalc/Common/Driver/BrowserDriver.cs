using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SeleniumGoogleCalc.Common
{
    public class BrowserDriver : IWebDriver
    {
        private readonly Browser browser;
        private readonly IWebDriver webDriver;

        /// <summary>
        /// Create instance of webDriver based on required browser
        /// </summary>
        /// <param name="browser"></param>
        public BrowserDriver(Browser browser)
        {
            this.browser = browser;
            webDriver = CreateDriver();
        }

        private IWebDriver CreateDriver()
        {
            if (webDriver == null)
            {
                return browser switch
                {
                    Browser.Chrome => ChromeDriver(),
                    Browser.Firefox => FirefoxDriver(),
                    Browser.IE => IEDriver(),
                    _ => throw new WebDriverException("Invalid browser name"),
                };
            }

            return webDriver;
        }

        private IWebDriver IEDriver()
        {
            try
            {
                return new InternetExplorerDriver();
            }
            catch (Exception ex)
            {
                throw new WebDriverException("Couldn't create IE driver" + " " + ex.InnerException);
            }
        }

        private IWebDriver FirefoxDriver()
        {
            try
            {
                return new InternetExplorerDriver();
            }
            catch (Exception ex)
            {
                throw new WebDriverException("Couldn't create Firefox driver" + " " + ex.InnerException);
            }
        }

        private IWebDriver ChromeDriver()
        {
            try
            {
                return new ChromeDriver();
            }
            catch (Exception ex)
            {
                throw new WebDriverException("Couldn't create Chrome driver" + " " + ex.InnerException);
            }
        }

        #region Interface
        public string Url
        {
            get => webDriver.Url;
            set => webDriver.Url = value;
        }

        public string Title => webDriver.Title;

        public string PageSource => webDriver.PageSource;

        public string CurrentWindowHandle => webDriver.CurrentWindowHandle;

        public ReadOnlyCollection<string> WindowHandles => webDriver.WindowHandles;

        public IWebDriver Driver() => webDriver;
        public void Close() => webDriver.Close();
        public void Dispose() => webDriver.Dispose();
        public IWebElement FindElement(By locator) => webDriver.FindElement(locator);
        public ReadOnlyCollection<IWebElement> FindElements(By locator) => webDriver.FindElements(locator);
        public IOptions Manage() => webDriver.Manage();
        public INavigation Navigate() => webDriver.Navigate();
        public void Quit() => webDriver.Quit();
        public ITargetLocator SwitchTo() => webDriver.SwitchTo();
        #endregion
    }
}
