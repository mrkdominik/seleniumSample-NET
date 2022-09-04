using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
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
        [Obsolete]
        public BrowserStackDriver(Browser browser)
        {
            _browser = browser;
            _webDriver = CreateDriverLegacy();
        }

        [Obsolete]
        private IWebDriver CreateDriverLegacy()
        {
            //todo: atm are caps hardcoded, but have to be separated away

            //Officially supported by BS, but obsolete, in future we will be force to explicit browserOptions solution..
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", _browser.ToString());
            caps.SetCapability("browserstack.user", "foo");
            caps.SetCapability("browserstack.key", "foo");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("osVersion", "10");
            caps.SetCapability("resolution", "1024x768");

            try
            {
                return new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps);
            }
            catch (Exception ex)
            {
                throw new WebDriverException($"Couldn't create BrowserStack driver {ex.Message}");
            }
        }

        #region Interface implementation
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