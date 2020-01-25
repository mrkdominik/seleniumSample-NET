using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SeleniumGoogleCalc.Common
{
    public class BrowserStackDriver : IWebDriver
    {
        readonly IWebDriver webDriver;
        readonly Browser environment;

        public BrowserStackDriver(Browser environment)
        {
            this.environment = environment;
            webDriver = CreateDriver();
        }

        private IWebDriver CreateDriver()
        {
            RemoteSessionSettings caps = new RemoteSessionSettings();
            caps.AddMetadataSetting("browser", environment);
            caps.AddMetadataSetting("os", "Windows");
            caps.AddMetadataSetting("os_version", "10");
            caps.AddMetadataSetting("resolution", "1024x768");
            caps.AddMetadataSetting("browserstack.user", "foo");
            caps.AddMetadataSetting("browserstack.key", "foo");

            return new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps);
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
