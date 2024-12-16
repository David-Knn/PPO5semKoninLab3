using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolveTabMathFunction.Lib;

namespace SolveTabMathFunction.Test
{
    [TestClass]
    public class ValidTabMathFunction
    {
        [TestMethod]
        public void TestCalculateTabMathFuction()
        {
            var tab = new TabMathFunction();
            int start = -5;
            int end = 5;

           

            int len = end - start + 1;
            double[] valueWaitArray = new double[len];

            valueWaitArray[0] = 457.88;  // f(-5)
            valueWaitArray[1] = 295.06;  // f(-4)
            valueWaitArray[2] = 169.01;   // f(-3)
            valueWaitArray[3] = 80.58;   // f(-2)
            valueWaitArray[4] = 0;      // f(-1)
            valueWaitArray[5] = 2;     // f(0)
            valueWaitArray[6] = 0;      // f(1) (неопределено)
            valueWaitArray[7] = 80.58;  // f(2)
            valueWaitArray[8] = 169.01;  // f(3)
            valueWaitArray[9] = 295.06;  // f(4)
            valueWaitArray[10] = 457.88; // f(5)


            double[] res = new double[len];
            res = tab.CalculateTabMathFunction(start, end);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}