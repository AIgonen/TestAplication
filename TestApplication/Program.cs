using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Browsers;
using TestApplication.Selenium;
using TestApplication.ExtensionMethods;

namespace TestApplication
{
    enum Browser
    {
        FireFox,
        Chrome,
        Safari,
        Edge
    }
    class Program
    {
        static void Main()
        {
            //NonGenericCollection();
            //GenericCollection();
            //User.GenericCollectionWithCustomClass();
            Console.WriteLine(GetBrowserName(Browser.Chrome));
            IWebDriver webDriver = new FireFox();
            webDriver.FindElement();
            Console.ReadKey();
        }

        public static string GetBrowserName(Browser browser)
        {
            if (browser.Equals(Browser.FireFox))
                return "firefox";
            else if (browser.Equals(Browser.Chrome))
                return "chrome";
            else if (browser.Equals(Browser.Safari))
                return "safari";
            else if (browser.Equals(Browser.Edge))
                return "edge";
            else
                return "I dont know that browser";
        }
        
    }

}
