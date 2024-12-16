namespace SolveMathFirstExpression.Lib
{
    public class MathFirstExpression
    {
        public double CalculateFirstExpression(double x, double y, double a)
        {
            double res =  (2 * y) + ((2 * 3 * a) / ((10 * x) - (3 * a))) + 2 * a;
            res = Math.Round(res, 2);
            return res;
        }
    }
}