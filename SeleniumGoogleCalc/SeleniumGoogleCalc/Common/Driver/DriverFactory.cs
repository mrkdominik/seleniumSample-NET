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
        protected Browser environment;

        public DriverFactory(Profile profile, Browser environment)
        {
            this.profile = profile;
            this.environment = environment;
        }

        [SetUp]
        public void Init()
        {
            if (profile == Profile.Local)
            {
                driver = new BrowserDriver(environment);                       
            }

            if (profile == Profile.RemoteBroweserStack)
            {
                driver = new BrowserStackDriver(environment);
            }
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
