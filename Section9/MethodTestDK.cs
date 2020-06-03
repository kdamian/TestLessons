using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class MethodTestDK
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, MathHelperDK.SquareRoot(16));
        }

        [TestMethod]
        public void TestMethod2()
        {            
            Assert.AreEqual(7, MathHelperDK.AddSomething(no2: 4));
        }

        [TestMethod]
        public void TupleTest()
        {
            //create the tuple
            Tuple<int, string, bool> myTuple = new Tuple<int, string, bool>(1, "DK", true);

            //access the tuple
            if (myTuple.Item1 == 1)
            {
                Console.WriteLine(myTuple.Item1);
            }

            if (myTuple.Item3)
            {
                Console.WriteLine(myTuple.Item3);
            }
        }
    }
}
