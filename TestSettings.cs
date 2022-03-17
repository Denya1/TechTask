using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    internal class TestSettings
    {   
        public static string HostPrefix = "https://tarasmysko89.wixsite.com/vectortesttask01";
        public static string LocationWix = "https://tarasmysko89.wixsite.com/vectortesttask01";
       //Positive scenario
        public static string _fullname = "Test Test";
        public static string _fullnameIncorect = "Test Test";
        public static string _email = "Test@test.com";
        public static string _TextButtonJoinNow = "Join Now";
        public static string _TextButtonJoinToday = "Join Today";

        //Negative scenario
        public static string _firstnameIncorect = "Test";
        public static string _firstname = "Test Test";
        public static string _emailincorect = "13421";
        public static string _emailincorect1 = "Testtestcom";
        public static string _emailincorect2 = "Test@testcom";
        public static string _emailincorect3 = "Testtest.com";
    }
}
