using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumToolkit.Common.Enums;

namespace SeleniumToolkit.Common.Drivers
{

    public static class DriverFactory
    {
        public static AppiumDriver CreateInstanceMobile(PlatformType platformType, string osVersion = null)
        {
            return new AppiumDriver(platformType, osVersion);
        }

        public static BrowserDriver CreateInstanceDesktop(Browser browser)
        {
            return new BrowserDriver(browser);
        }

        public static BrowserStackDriver CreateInstanceBrowserStack(Browser browser)
        {
            return new BrowserStackDriver(browser);
        }
    }
}
