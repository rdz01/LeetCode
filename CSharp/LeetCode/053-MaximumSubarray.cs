namespace LeetCode
{
    public class _053_MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int result = int.MinValue;
            int temp = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                temp = temp + nums[i] > nums[i] ? temp + nums[i] : nums[i];
                if (result < temp)
                {
                    result = temp;
                }
            }

            return result;
        }
    }
}
