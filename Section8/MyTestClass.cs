using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class MyTestClass
    {
        
        public void TestMethod1()
        {
            var number = 1;
            while (number < 11)
            {
                Console.WriteLine(number);
                number++;
            }
            
        }

        [TestMethod]
        public void Sentinel_loop()
        {

        }
    }
}
