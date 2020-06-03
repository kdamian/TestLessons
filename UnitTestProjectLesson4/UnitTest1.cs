using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectLesson4
{
    [TestClass]
    [TestCategory("DKtest")]     
    public class UnitTest1
    {
        private int a;

        [TestInitialize]
        public void RunBeforeEveryTest()
        {
            a = 1;
        }

        [TestMethod]
        [Description("these are demo unit tests")]
        public void TestMethod1()
        {
            var b = 2;
            Assert.AreEqual(3, a + b);
        }

        [TestMethod]        
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod2()
        {
            Assert.AreNotEqual(1, a);            
        }
    }
}
