using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumGoogleCalc.Common.Enums;

namespace SeleniumGoogleCalc.Common.Drivers
{
    public class BrowserStackDriver : IWebDriver
    {
        readonly IWebDriver _webDriver;
        readonly Browser _browser;

        /// <summary>
        /// Create a new BrowserStackDriver for wanted Browser
        /// </summary>
        /// <param name="browser"></param>
        public BrowserStackDriver(Browser browser)
        {
            _browser = browser;
            _webDriver = CreateDriver();
        }

        private IWebDriver CreateDriver()
        {
            try
            {
                //todo: extract variables into tuple configuration class, passed into driver on input
                //todo: atm are caps hardcoded, but have to be separated away

                RemoteSessionSettings caps = new RemoteSessionSettings();
                caps.AddMetadataSetting("browser", _browser);
                caps.AddMetadataSetting("os", "Windows");
                caps.AddMetadataSetting("os_version", "10");
                caps.AddMetadataSetting("resolution", "1024x768");
                caps.AddMetadataSetting("browserstack.user", "test21332");
                caps.AddMetadataSetting("browserstack.key", "tHoXzq5u3YbSDum1BByd");

                return new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps);
            }
            catch (Exception ex)
            {
                throw new WebDriverException($"Couldn't create BrowserStack driver {ex.Message}");
            }
        }

        #region Interface
        public string Url
        {
            get => _webDriver.Url;
            set => _webDriver.Url = value;
        }
        public string Title => _webDriver.Title;
        public string PageSource => _webDriver.PageSource;
        public string CurrentWindowHandle => _webDriver.CurrentWindowHandle;
        public ReadOnlyCollection<string> WindowHandles => _webDriver.WindowHandles;
        public void Close() => _webDriver.Close();
        public void Dispose() => _webDriver.Dispose();
        public IWebElement FindElement(By locator) => _webDriver.FindElement(locator);
        public ReadOnlyCollection<IWebElement> FindElements(By locator) => _webDriver.FindElements(locator);
        public IOptions Manage() => _webDriver.Manage();
        public INavigation Navigate() => _webDriver.Navigate();
        public void Quit() => _webDriver.Quit();
        public ITargetLocator SwitchTo() => _webDriver.SwitchTo();
        #endregion

    }
}