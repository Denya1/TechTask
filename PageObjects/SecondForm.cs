using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest.PageObjects
{
    internal class SecondForm
    {

        private IWebDriver _webDriver;

        private readonly By _inputfirstname = By.CssSelector("#input_comp-jxd8gc8n");
        private readonly By _inputemail = By.CssSelector("#input_comp-jxd8gc99");
        private readonly By _singJoinToday = By.XPath("//div[@id='comp-jxd8gc9k']/button");
        private readonly By _InscriptionSuccessSing = By.XPath("//div[@id='comp-jxd8gc9w']");
        public string TextButton ;
        public SecondForm(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void Inputfullname(string fullname)
        {
            WaitUntil.WaitElementIsVis(_webDriver, _inputfirstname);
            _webDriver.FindElement(_inputfirstname).SendKeys(fullname);

        }
        public void Inputemail(string email)
        {
            WaitUntil.WaitElementIsVis(_webDriver, _inputemail);
            _webDriver.FindElement(_inputemail).SendKeys(email);
        }
        public void SingJohnow()
        {
            WaitUntil.WaitElementBeClick(_webDriver, _singJoinToday);
            _webDriver.FindElement(_singJoinToday).Click();
        }
        public string ElementText()
        {

            WaitUntil.WaitElementBeClick(_webDriver, _singJoinToday);
            TextButton = _webDriver.FindElement(_singJoinToday).Text;
            return TextButton;

        }
        public bool CheckInscriptionSuccessSing()
        {

            try
            {
                Thread.Sleep(2000); //I understand this method is not as well suited

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
