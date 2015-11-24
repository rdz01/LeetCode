namespace LeetCode
{
    public class _042_TrappingRainWater
    {
        public int Trap(int[] height)
        {
            int n = height.Length;
            int[] maxLeft = new int[n],
                  maxRight = new int[n];

            for (int i = 1; i < n; i++)
            {
                maxLeft[i] = maxLeft[i - 1] > height[i - 1] ? maxLeft[i - 1] : height[i - 1];
                maxRight[n - i - 1] = maxRight[n - i] > height[n - i] ? maxRight[n - i] : height[n - i];
            }

            int minHeight, result = 0;
            for (int i = 0; i < n; i++)
            {
                minHeight = maxLeft[i] < maxRight[i] ? maxLeft[i] : maxRight[i];
                if (minHeight > height[i])
                {
                    result += minHeight - height[i];
                }
            }

            return result;
        }
    }
}
