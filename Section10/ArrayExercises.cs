using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section10
{
    [TestClass]
    public class ArrayExercises
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] tab = new string[] {"7", "2", "4", "2", "q", "87", "4", "6", "4", "4", "7"};
            Assert.AreEqual(9, CheckTabForIntegers(tab));
        }

        public int CheckTabForIntegers(string[] scores)
        {
            int sum = 0;
            foreach (var i in scores)
            {
                while (int.TryParse(i, out int result) == false)
                {
                    //try to figure out how to work TryParse()...
                }

                if (int.Parse(i) >= 0 && int.Parse(i) <= 10)
                {
                    sum += 1;
                }
            }

            return sum;
        }
    }
}
