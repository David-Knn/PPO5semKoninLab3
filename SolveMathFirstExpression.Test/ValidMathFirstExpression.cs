using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolveMathFirstExpression.Lib;

namespace SolveMathFirstExpression.Test
{
    [TestClass]
    public class ValidMathFirstExpression
    {
        [TestMethod]
        public void TestCalculateFirstExpression()
        {
            var exp1 = new MathFirstExpression();
            double x = 2, y = 3, a = 1;
            double expected = 8.35;
            double result = exp1.CalculateFirstExpression(x, y, a);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}