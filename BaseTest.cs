using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class BaseTest
    {
        protected IWebDriver _webDriver;

        [OneTimeSetUp]
        protected void DoBeforeALL()
        {
            //string path = "C:\\Users\\Юрий\\source\\repos\\TestProject1\\TestProject1\\Drivers\\";
            //driver = new ChromeDriver("C:\\self_education\\automation");
            ChromeOptions _options = new ChromeOptions();
            _options.AddArguments("--disable-blink-features");
            _options.AddArguments("--disable-blink-features=AutomationControlled");

            _webDriver = new ChromeDriver("C:\\self_education\\automation", options: _options);            
        }

        [OneTimeTearDown]
        protected void DoAfterAllTheTests()
        {
            _webDriver.Quit();


        }

        [SetUp]
        protected void DoBeforEach()
        {
            //_webDriver = new ChromeDriver("C:\\self_education\\automation", options: _options);
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(TestSettings.HostPrefix);

        }
        [TearDown]
        protected void DoAfterEach()
        {
            //_webDriver.Quit();

        }
        
      

    }   




}
