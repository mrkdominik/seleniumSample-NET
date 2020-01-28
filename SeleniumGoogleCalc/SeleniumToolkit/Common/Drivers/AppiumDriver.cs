using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.ObjectModel;

namespace SeleniumToolkit.Common.Drivers
{
    public class AppiumDriver : IWebDriver
    {
        private IWebDriver _webDriver;
        readonly PlatformType _platformType;
        private readonly string _osVersion;

        public AppiumDriver(PlatformType platformType, string osVersion)
        {
            _platformType = platformType;
            _osVersion = osVersion;

            if (_platformType == PlatformType.Android 
                && !string.IsNullOrEmpty(_osVersion))
                _webDriver = CreateDriver();
            else
                throw new ArgumentException("Provided PlatformType is not a mobile one or platform Version is not set");
        }

        private IWebDriver CreateDriver()
        {
            try
            {
                RemoteSessionSettings caps = new RemoteSessionSettings();
                caps.AddMetadataSetting("browser", _platformType);
                caps.AddMetadataSetting("os_version", _osVersion);
                _webDriver = new RemoteWebDriver(new Uri("foo"), caps);
            }
            catch (Exception ex)
            {
                throw new WebDriverException("Couldn't create Appium driver" + " " + ex.InnerException);
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
