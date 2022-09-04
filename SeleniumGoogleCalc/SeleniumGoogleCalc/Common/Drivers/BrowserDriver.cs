﻿using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Extensions;
using SeleniumGoogleCalc.Common.Enums;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using WebDriverManager;

namespace SeleniumGoogleCalc.Common.Drivers
{
    public class BrowserDriver : IWebDriver
    {
        private readonly Browser _browser;
        private IWebDriver _webDriver;

        /// <summary>
        /// Create new local instance of webDriver based on required browser
        /// </summary>
        /// <param name="browser"></param>
        /// 
        public BrowserDriver(Browser browser)
        {
            _browser = browser;
            _webDriver = CreateDriver();
        }

        private IWebDriver CreateDriver()
        {
            if (_webDriver != null)
                return _webDriver;

            return _browser switch
            {
                Browser.Chrome => ChromeDriver(),
                Browser.Edge => MsEdgeDriver(),
                Browser.Ie => IeDriver(),
                Browser.Safari => throw new NotImplementedException($"{_browser} browser not implemented yet"),
                Browser.Firefox => throw new NotImplementedException($"{_browser} browser not implemented yet"),
                Browser.Opera => throw new NotImplementedException($"{_browser} browser not implemented yet"),
                Browser.PhantomJs => throw new NotImplementedException($"{_browser} browser not implemented yet"),
                _ => throw new WebDriverException("Invalid browser name"),
            };
        }

        private IWebDriver MsEdgeDriver()
        {
            try
            {
                new DriverManager().SetUpDriver(new EdgeConfig(), VersionResolveStrategy.MatchingBrowser);
                return new EdgeDriver();
            }
            catch (Exception ex)
            {
                throw new WebDriverException($"Couldn't create {_browser} driver {ex.Message}");
            }
        }

        private IWebDriver ChromeDriver()
        {
            try
            {
                new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
                return new ChromeDriver();
            }
            catch (Exception ex)
            {
                throw new WebDriverException($"Couldn't create {_browser} driver {ex.Message}");
            }
        }

        private IWebDriver IeDriver()
        {
            try
            {
                new DriverManager().SetUpDriver(new EdgeConfig(), VersionResolveStrategy.MatchingBrowser);
                return new InternetExplorerDriver();
            }
            catch (Exception ex)
            {
                throw new WebDriverException($"Couldn't create Chrome driver {ex.Message}");
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
        public object ExecuteScript(string script, params object[] args) => ExecuteScript(script, args);
        public IJavaScriptExecutor ExecuteJavaScript(string script, params object[] args) => ExecuteJavaScript(script, args);

        #endregion
    }
}
