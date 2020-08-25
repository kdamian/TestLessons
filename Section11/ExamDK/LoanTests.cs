using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDK
{
    [TestClass]
    public class LoanTests
    {
        [TestMethod]
        public void Test()
        {
            AutoLoan car = new AutoLoan(123, "Donkey", "Kong", .075, 50000, 3, 2015, "Subaru", "New", "Blue");
            decimal interest = car.CalculateInterest();
            
            Assert.AreEqual((decimal)106.25, interest);
            Console.WriteLine(car);
        }
    }
}
