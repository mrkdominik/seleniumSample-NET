using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumGoogleCalc.SeleniumHelpers
{
    class SeleniumHelper
    {
        private readonly IWebDriver _driver;

        public SeleniumHelper(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ResetDriver() 
        {
            try
            {
                if (_driver != null)
                {
                    _driver.Close();
                    _driver.Quit();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("webDriver can not be reset properly", ex);
            }
        }
    }
}
