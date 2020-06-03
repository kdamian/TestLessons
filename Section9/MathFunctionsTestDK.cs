using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class MathFunctionsTestDK
    {
        [TestMethod]
        public void TestMathFunctions()
        {
            //Act
            MathFunctionsDK math = new MathFunctionsDK();

            //Arrange
            double a = 5;

            //Assert
            Assert.AreEqual(25, MathFunctionsDK.SquareRoot(a));
        }
    }
}
