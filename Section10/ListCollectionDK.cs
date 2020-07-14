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

            int sum = sumList(ValidationOfList(dataList));

            Assert.AreEqual(sum, 147);
        }

        public ArrayList ValidationOfList(ArrayList dataList)
        {
            ArrayList goodValues = new ArrayList();

            foreach (var item in dataList)
            {
                if (int.TryParse(item.ToString(), out int result))
                {
                    goodValues.Add(result);
                }
            }

            return goodValues;
        }

        public int sumList(ArrayList dataList)
        {
            int sum = 0;

            foreach (int item in dataList)
            {
                sum += item;
            }

            return sum;
        }
    }
}
