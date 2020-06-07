using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class PropertyTaxCalcTestDK
    {
        [TestMethod]
        public void TestNewAssessedValue()
        {
            PropertyTaxCalcDK home1 = new PropertyTaxCalcDK("SanDiego", 50000, 60000);
            Assert.AreEqual(51350M, home1.CalculateNewAssessedValue());            
        }

        [TestMethod]
        public void TestTaxesDue()
        {
            PropertyTaxCalcDK home1 = new PropertyTaxCalcDK("SanDiego", 50000, 60000);
            Assert.AreEqual(351.05M, home1.CalculateTaxesDue());
        }

        [TestMethod]
        public void TestTaxableValue()
        {
            PropertyTaxCalcDK home1 = new PropertyTaxCalcDK("SanDiego", 50000, 60000);
            Assert.AreEqual(35000M, home1.CalculateTaxableValue());
        }

        [TestMethod]
        public void TestOutput()
        {
            PropertyTaxCalcDK home1 = new PropertyTaxCalcDK("SanDiego", 50000, 60000);
            Console.WriteLine(home1);
        }
    }
}
