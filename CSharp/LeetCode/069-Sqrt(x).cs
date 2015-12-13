namespace LeetCode
{
    public class _069_Sqrt
    {
        public int MySqrt(int x)
        {
            if (x < 2) { return x; }

            long value;
            int start = 0, mid, end = x / 2;
            while (end >= start)
            {
                mid = start + (end - start) / 2;
                value = mid * (long)mid;

                if (value < x) { start = mid + 1; }
                else if (value > x) { end = mid - 1; }
                else { return mid; }
            }

            return end;
        }
    }
}
