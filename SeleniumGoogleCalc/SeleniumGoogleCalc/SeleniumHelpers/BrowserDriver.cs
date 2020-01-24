using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.ObjectModel;

namespace SeleniumGoogleCalc.SeleniumHelpers
{

    public partial class BrowserDriver : IWebDriver
    {

        private Browser browser;
        private IWebDriver webDriver;

        public string Url
        {
            get => webDriver.Url;
            set => webDriver.Url = value;
        }

        public string Title => webDriver.Title;

        public string PageSource => webDriver.PageSource;

        public string CurrentWindowHandle => webDriver.CurrentWindowHandle;

        public ReadOnlyCollection<string> WindowHandles => webDriver.WindowHandles;

        /// <summary>
        /// Create instance of webDriver based on supplied browser
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
                switch (browser)
                {
                    case Browser.Chrome:
                        return ChromeDriver();
                    case Browser.Firefox:
                        return FirefoxDriver();
                    case Browser.IE:
                        return IEDriver();
                }

                throw new WebDriverException("Invalid browser name");
            }

            return webDriver;
        }

        private IWebDriver IEDriver()
        {
            try
            {
                return new InternetExplorerDriver();
            }
            catch (Exception)
            {
                throw new WebDriverException("Couldn't create IE driver");
            }
        }

        private IWebDriver FirefoxDriver()
        {
            try
            {
                return new InternetExplorerDriver();
            }
            catch (Exception)
            {
                throw new WebDriverException("Couldn't create Firefox driver");
            }
        }

        private IWebDriver ChromeDriver()
        {
            try
            {
                return new ChromeDriver();
            }
            catch (Exception)
            {
                throw new WebDriverException("Couldn't create Chrome driver");
            }
        }

        /// <summary>
        /// Get extended webdriver.
        /// </summary>
        /// <returns>IWebDriver</returns>
        public IWebDriver Driver() => webDriver;
        public void Close() => webDriver.Close();
        public void Dispose() => webDriver.Dispose();
        public IWebElement FindElement(By locator) => webDriver.FindElement(locator);
        public ReadOnlyCollection<IWebElement> FindElements(By locator) => webDriver.FindElements(locator);
        public IOptions Manage() => webDriver.Manage();
        public INavigation Navigate() => webDriver.Navigate();
        public void Quit() => webDriver.Quit();
        public ITargetLocator SwitchTo() => webDriver.SwitchTo();

    }
}
