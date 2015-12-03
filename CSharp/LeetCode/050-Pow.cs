namespace LeetCode
{
    public class _050_Pow
    {
        public double MyPow(double x, int n)
        {
            if (x == 0) { return 0; }

            var sign = false;
            if (n < 0)
            {
                n = -n;
                sign = true;
            }

            double result = 1;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    result *= x;
                }
                n = n >> 1;
                x = x * x;
            }

            return sign ? 1 / result : result;
        }
    }
}
