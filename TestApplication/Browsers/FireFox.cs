using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Selenium;

namespace TestApplication.Browsers
{
    class FireFox : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Click the element");
        }

        public void FindElement()
        {
            Console.WriteLine("Find UI element in FireFox");
        }

        public void SendKeys(string keys)
        {
            Console.WriteLine("Send the text");
        }
    }
}

