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

            ValidationOfList(dataList);

            foreach (var i in dataList)
            {
                Console.WriteLine(i);
            }

            
        }

        public ArrayList ValidationOfList(ArrayList dataList)
        {
            int i = 0;
            
            ArrayList placeWithNoNumber = new ArrayList();

            foreach (var item in dataList)
            {

                if (!double.TryParse(item.ToString(), out double result))
                {
                    placeWithNoNumber.Add(i); 
                }
                i++;
            }

            foreach (var item in placeWithNoNumber)
            {
                int.TryParse(item.ToString(), out int result);
                dataList.RemoveAt(result);
            }

            return dataList;
        }
    }
}
