namespace LeetCode
{
    public class _069_Sqrt
    {
        public int MySqrt(int x)
        {
            if (x < 1) { return x; }

            double last = 0.0, result = 1.0;
            while (last != result)
            {
                last = result;
                result = (result + x / result) / 2;
            }

            return (int)last;
        }
    }
}
