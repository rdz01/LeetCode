namespace LeetCode
{
    public class _011_ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var start = 0;
            var end = height.Length - 1;
            var result = 0;
            var area = 0;
            var temp = 0;

            while (start < end)
            {
                area = (height[start] < height[end] ? height[start] : height[end]) * (end - start);
                result = result < area ? area : result;
                if (height[start] <= height[end])
                {
                    temp = height[start];
                    do
                    {
                        start++;
                    } while (start < end && height[start] <= temp);
                }
                else
                {
                    temp = height[end];
                    do
                    {
                        end--;
                    } while (start < end && height[end] <= temp);
                }
            }
            return result;
        }
    }
}
