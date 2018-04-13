using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalizationTest.UnitTest
{
    [TestFixture]
    public class SampleTestCases
    {
        [TestCase]
        public void TestOne()
        {
            //TestableClass testSample = new TestableClass();
            //testSample.m_currentLanguage = "zh";

            TestableClass.currentLanguage = "zh";
            Assert.AreEqual("zh", TestableClass.currentLanguage);
        }

        [TestCase]
        public void TestTwo()
        {
            TestableClass.currentLanguage = "jp";// "CHINESE";
            Assert.AreEqual("jp", TestableClass.currentLanguage);
        }
    }
}