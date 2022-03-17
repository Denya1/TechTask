using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    
    public static class WaitUntil
    {
        public static void WaitElementIsVis(IWebDriver webDriver, By locator, int second=10)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(second)).Until(ExpectedConditions.ElementIsVisible(locator)); 
            
        }
        public static void WaitElementBeClick(IWebDriver webDriver, By locator, int second = 10)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(second)).Until(ExpectedConditions.ElementToBeClickable(locator));


        }
        public static void WaitElementBeSelect(IWebDriver webDriver, By locator, int second = 10)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(second)).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));


        }
    }
}
