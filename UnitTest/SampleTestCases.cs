using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalizationTest.UnitTest
{
    [TestFixture]
    public class SampleTestCases_DEV
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

        [TestCase]
        public void TestThree()
        {
            TestableClass.currentLanguage = "";// "CHINESE";
            Assert.AreEqual("", TestableClass.currentLanguage);
        }

    }

    [TestFixture]
    public class SampleTestCases_SMOKE
    {
        [TestCase]
        public void TestOneSmoke()
        {
            //TestableClass testSample = new TestableClass();
            //testSample.m_currentLanguage = "zh";

            TestableClass.currentLanguage = "zh";
            Assert.AreEqual("zh", TestableClass.currentLanguage);
        }

        [TestCase]
        public void TestTwoSmoke()
        {
            TestableClass.currentLanguage = "jp";// "CHINESE";
            Assert.AreEqual("jp", TestableClass.currentLanguage);
        }

        [TestCase]
        public void TestThreeSmoke()
        {
            TestableClass.currentLanguage = "";// "CHINESE";
            Assert.AreEqual("", TestableClass.currentLanguage);
        }

    }
}