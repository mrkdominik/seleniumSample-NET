using SeleniumGoogleCalc.Common.Enums;
using System;

namespace SeleniumGoogleCalc.Common.Drivers
{
    public static class DriverFactory
    {
        public static BrowserDriver CreateInstanceDesktop(Browser browser)
        {
            return new BrowserDriver(browser);
        }

        [Obsolete]
        public static BrowserStackDriver CreateInstanceBrowserStack(Browser browser)
        {
            return new BrowserStackDriver(browser);
        }
    }
}