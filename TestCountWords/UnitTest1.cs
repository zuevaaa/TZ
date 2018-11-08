using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TZ;

namespace TestCountWords
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_no_ts()
        {
            Assert.AreEqual(0, Form1.countWordsStartWithT("ёмаё"));
            Assert.AreEqual(0, Form1.countWordsStartWithT("что-то навроде этого"));
            Assert.AreEqual(0, Form1.countWordsStartWithT("или вот"));
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void test_ts()
        {
            Assert.AreEqual(1, Form1.countWordsStartWithT("так-так"));
            Assert.AreEqual(1, Form1.countWordsStartWithT("Тост горяч"));
            Assert.AreEqual(1, Form1.countWordsStartWithT("или Так"));
            Assert.AreEqual(2, Form1.countWordsStartWithT("Tak tozhe"));
            Assert.AreEqual(2, Form1.countWordsStartWithT("tak тozhe"));
        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void test_empty_field()
        {
            Assert.AreEqual(0, Form1.countWordsStartWithT(""));

        }
    }
}

