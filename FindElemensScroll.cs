using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    internal static class FindElemensScroll
    {
        public static void Find(IWebDriver webDriver, By locator)
        {
            var element = webDriver.FindElement(locator);
            Actions actions = new Actions(webDriver);
            actions.MoveToElement(element);
            actions.Perform();
        }
           
    }
}
