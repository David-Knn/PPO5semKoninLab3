namespace SolveMathSecondExpression.Lib
{
    public class MathSecondExpression
    {
        public double CalculateSecondExpression(double x, double y, double a)
        {
            double res = 7 + (((a * x) / (2 * y)) / ((3 + a) / x)) * y - ((2 * x) + y + x - (3 * a)) / (a + x - (8 * y));
            res = Math.Round(res, 2);
            return res;
        }
    }
}