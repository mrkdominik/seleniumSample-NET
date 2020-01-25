using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;


namespace SeleniumGoogleCalc.Common
{
    [TestFixture]
    public class DriverFactory
    {
        protected IWebDriver driver;
        protected Profile profile;
        protected Browser browser;

        /// <summary>
        /// Creates new instance of  local or remote IWebDriver
        /// </summary>
        /// <param name="profile">Local/Remote</param>
        /// <param name="browser">Browser</param>
        public DriverFactory(Profile profile, Browser browser)
        {
            this.profile = profile;
            this.browser = browser;
        }

        [SetUp]
        public void Init()
        {
            if (profile == Profile.Local)
                driver = new BrowserDriver(browser);                       

            if (profile == Profile.RemoteBroweserStack)
                driver = new BrowserStackDriver(browser);
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
