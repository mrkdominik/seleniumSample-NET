﻿using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumToolkit.Common.Enums;

namespace SeleniumToolkit.Common.Drivers
{
    public class BrowserStackDriver : IWebDriver
    {
        private IWebDriver _webDriver;
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
                RemoteSessionSettings caps = new RemoteSessionSettings();
                caps.AddMetadataSetting("browser", _browser);
                caps.AddMetadataSetting("os", "Windows");
                caps.AddMetadataSetting("os_version", "10");
                caps.AddMetadataSetting("resolution", "1024x768");
                caps.AddMetadataSetting("browserstack.user", "foo"); //TODO: extract it out of package
                caps.AddMetadataSetting("browserstack.key", "foo");

                _webDriver = new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps);
            }
            catch (Exception ex)
            {
                throw new WebDriverException("Couldn't create BrowserStack driver" + " " + ex.InnerException);
            }

            return _webDriver;
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