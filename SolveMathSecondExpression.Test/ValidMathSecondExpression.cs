using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolveMathSecondExpression.Lib;

namespace SolveMathSecondExpression.Test
{
    [TestClass]
    public class ValidMathSecondExpression
    {
        [TestMethod]
        public void TestCalculateSecondExpression()
        {
            var exp2 = new MathSecondExpression();
            double x = 2, y = 3, a = 1;
            double expected = 7.79;
            double result = exp2.CalculateSecondExpression(x, y, a);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}