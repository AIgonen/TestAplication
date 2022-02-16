using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Selenium;

namespace TestApplication.Browsers
{
    class Edge : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Click the element");
        }

        public void FindElement()
        {
            throw new NotImplementedException("Find UI element in Edge");
        }

        public void SendKeys(string keys)
        {
            throw new NotImplementedException("Send the text");
        }
    }
}

