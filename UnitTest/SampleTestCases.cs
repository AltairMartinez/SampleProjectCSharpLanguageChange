using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalizationTest.UnitTest
{
    public class SampleTestCases
    {
        [TestCase]
        public void TestOne()
        {
            TestableClass testSample = new TestableClass();
            testSample.m_currentLanguage = "zh";

            Assert.AreEqual("zh", testSample.m_currentLanguage);
        }

        //[TestCase]
        //public void TestTwo()
        //{
        //    TestableClass testSample = new TestableClass();
        //    testSample.m_currentLanguage = "booby";

        //    Assert.AreEqual("booby", testSample.m_currentLanguage);
        //}

    }
}