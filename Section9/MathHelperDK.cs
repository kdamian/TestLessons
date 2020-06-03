using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class MathHelperDK
    {
        public static double SquareRoot(double d)
        {
            return Math.Sqrt(d);
        }

        public static int AddSomething(int no1 = 3, int no2 = 5)
        {
            return no1 + no2;
        }


    }
}
