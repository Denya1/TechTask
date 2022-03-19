//Inside SeleniumTest.cs

using NUnit.Framework;

using SeleniumTest;
using SeleniumTest.PageObjects;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Firefox;

using System;

using System.Collections.ObjectModel;

using System.IO;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumCsharp

{
    [TestFixture]
    public class TestsFirstForm: BaseTest   

    {
        [Test]

        public void validFullnameAndEmailFieldsIsOk()

        {
            var mainmenu = new FirstForm(_webDriver);
            //Thread.Sleep(1000);//I understand this method is not as well suited
            mainmenu.Inputfullname(TestSettings._fullname);
            mainmenu.Inputemail(TestSettings._email);
            mainmenu.SingJohnow();
            Assert.IsTrue(mainmenu.CheckInscriptionSuccessSing());

        }


        [Test]

        public void emptyEmailFieldIsRejected()

        {
            var mainmenu = new FirstForm(_webDriver);
            mainmenu.Inputfullname(TestSettings._fullname);
            mainmenu.Inputemail("");
            mainmenu.SingJohnow();
            Assert.IsFalse(mainmenu.CheckInscriptionSuccessSing());

        }
        [Test]

        public void incorectEmailFieldIsRejected()

        {
            var mainmenu = new FirstForm(_webDriver);
            mainmenu.Inputfullname(TestSettings._fullname);
            mainmenu.Inputemail(TestSettings._emailincorect);
            mainmenu.SingJohnow();
            Assert.IsFalse(mainmenu.CheckInscriptionSuccessSing());

        }

        [Test]
        public void CheckTextButtonSignIn()

        {
            var mainmenu = new FirstForm(_webDriver);
            string textbuttom = mainmenu.ElementText();

            Assert.AreEqual(TestSettings._TextButtonJoinNow, textbuttom);

        }



    }

    public class TestsSecondForm : BaseTest
    {
        [Test]

        public void IncorectEmailINTFieldIsRejected()

        {
            var mainmenu = new SecondForm(_webDriver);
            mainmenu.Inputfullname(TestSettings._firstname);
            mainmenu.Inputemail(TestSettings._emailincorect);
            mainmenu.SingJohnow();
            Assert.IsFalse(mainmenu.CheckInscriptionSuccessSing());

        }

        [Test]

        public void validFirstNameAndEmailFieldIsOk()

        {
            var mainmenu = new SecondForm(_webDriver);
            mainmenu.Inputfullname(TestSettings._fullname);
            mainmenu.Inputemail(TestSettings._email);
            mainmenu.SingJohnow();
            Assert.IsTrue(mainmenu.CheckInscriptionSuccessSing());

        }

        [Test]

        public void incorectEmailWITHOutPointFieldIsRejected()

        {
            var mainmenu = new SecondForm(_webDriver);
            mainmenu.Inputfullname(TestSettings._fullname);
            mainmenu.Inputemail(TestSettings._emailincorect2);
            mainmenu.SingJohnow();
            Assert.IsFalse(mainmenu.CheckInscriptionSuccessSing());

        }
        [Test]
        public void CheckTextButtonSignIn()

        {
            var mainmenu = new SecondForm(_webDriver);
            string textbuttom = mainmenu.ElementText();

            Assert.AreEqual(TestSettings._TextButtonJoinToday, textbuttom);

        }

    }
  
    

}
