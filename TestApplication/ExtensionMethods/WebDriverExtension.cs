using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Selenium;

namespace TestApplication.ExtensionMethods
{
    public static class WebDriverExtension
    {
        public static void SendKeysWithSplChar(this IWebDriver driver, string keys, string SplChar)
        {
            driver.SendKeys(keys);
            driver.SendKeys(SplChar);
        }
    }
}
