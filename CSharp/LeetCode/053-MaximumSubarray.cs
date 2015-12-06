namespace LeetCode
{
    public class _053_MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int result = int.MinValue;
            int[] sum = new int[nums.Length + 1];

            sum[0] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum[i + 1] = sum[i] + nums[i] > nums[i] ? sum[i] + nums[i] : nums[i];
                if (result < sum[i + 1])
                {
                    result = sum[i + 1];
                }
            }

            return result;
        }
    }
}
