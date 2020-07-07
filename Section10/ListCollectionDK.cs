using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section10
{
    [TestClass]
    public class ListCollectionDK
    {
        [TestMethod]
        public void TestMethod1()
        {
            ArrayList dataList = new ArrayList();

            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("app");
            dataList.Add("13.5");
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball soup");
            dataList.Add(18M);
            dataList.Add("pieces");
            dataList.Add("14");
        }

        public int TotalScore(object dataList)
        {
            return 0;
        }
    }
}
