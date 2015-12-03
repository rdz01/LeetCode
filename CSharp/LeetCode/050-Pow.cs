namespace LeetCode
{
    public class _050_Pow
    {
        public double MyPow(double x, int n)
        {
            if (x == 0) { return 0; }

            if (n < 0)
            {
                n = -n;
                x = 1 / x;
            }

            double result = 1;
            while (n > 0)
            {
                if ((n & 0x1) == 1)
                {
                    result *= x;
                }
                n = n >> 1;
                x = x * x;
            }

            return result;
        }
    }
}
