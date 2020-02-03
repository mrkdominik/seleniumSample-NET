using SeleniumGoogleCalc.Common.Enums;

namespace SeleniumGoogleCalc.Common.Drivers
{
    public static class DriverFactory
    {
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