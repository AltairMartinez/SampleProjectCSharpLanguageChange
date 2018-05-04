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
        [TestCase, Category("PreDeploy")]
        public void TestOne()
        {
            //TestableClass testSample = new TestableClass();
            //testSample.m_currentLanguage = "zh";

            TestableClass.currentLanguage = "zh";
            Assert.AreEqual("zh", TestableClass.currentLanguage);
        }

        [TestCase, Category("PreDeploy")]
        public void TestTwo()
        {
            TestableClass.currentLanguage = "jp";// "CHINESE";
            Assert.AreEqual("jp", TestableClass.currentLanguage);
        }

        [TestCase, Category("PreDeploy")]
        public void TestThree()
        {
            TestableClass.currentLanguage = "";// "CHINESE";
            Assert.AreEqual("", TestableClass.currentLanguage);
        }



    }

    [TestFixture]
    public class SampleTestCases_SMOKETEST
    {
        [TestCase, Category("PreDeploy")]
        public void TestFour()
        {
            TestableClass.currentLanguage = "";// "CHINESE";
            Assert.AreEqual("", TestableClass.currentLanguage);
        }

        [TestCase, Category("PostDeploy")]
        public void TestOneSmoke()
        {
            //TestableClass testSample = new TestableClass();
            //testSample.m_currentLanguage = "zh";

            TestableClass.currentLanguage = "zh";
            Assert.AreEqual("zh", TestableClass.currentLanguage);
        }

        [TestCase, Category("PostDeploy")]
        public void TestTwoSmoke()
        {
            TestableClass.currentLanguage = "jp";// "CHINESE";
            Assert.AreEqual("jp", TestableClass.currentLanguage);
        }
    }

}