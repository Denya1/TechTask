using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest.PageObjects
{
     class FirstForm
    {
        private IWebDriver _webDriver;

        private readonly By _inputfullname = By.CssSelector("#input_comp-jxd8gccb");
        private readonly By _inputemail = By.CssSelector("#input_comp-k5hb1d85");
        ////span[@class='_1Qjd7' and contains(text(), 'Now')]
        private readonly By _singJoinNow = By.XPath("//div[@id='comp-jxd8gccw']/button/span");
        private readonly By _InscriptionSuccessSing = By.XPath("//div[@id='comp-k5h9ba5e']");
        public string TextButton ;
        public FirstForm(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        
        public void Inputfullname(string fullname)
        {
            FindElemensScroll.Find(_webDriver, _inputfullname);
            WaitUntil.WaitElementIsVis(_webDriver, _inputfullname);
            _webDriver.FindElement(_inputfullname).SendKeys(fullname);
           
        }
        public void Inputemail(string email)
        {
           FindElemensScroll.Find(_webDriver, _inputemail);
           WaitUntil.WaitElementIsVis(_webDriver, _inputemail);
            _webDriver.FindElement(_inputemail).SendKeys(email);
        }
        public void SingJohnow()
        {
            WaitUntil.WaitElementBeClick(_webDriver, _singJoinNow);
            _webDriver.FindElement(_singJoinNow).Click();
        }

        public string ElementText()
        {
            
            WaitUntil.WaitElementBeClick(_webDriver, _singJoinNow);
            TextButton = _webDriver.FindElement(_singJoinNow).Text;
            return TextButton;

        }

        public bool CheckInscriptionSuccessSing()
        {
           
                try
                {
                Thread.Sleep(2000);//I understand this method is not as well suited

                var iv = _webDriver.FindElement(_InscriptionSuccessSing).Displayed;
              
            
                return iv;
                   
                
                }
                catch (NoSuchElementException)
                {
                return false;
                }
           

        }





    }
}
