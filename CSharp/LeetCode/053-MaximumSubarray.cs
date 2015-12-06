namespace LeetCode
{
    public class _053_MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int temp, result = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                temp = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    temp += nums[j];
                    if (result < temp)
                    {
                        result = temp;
                    }
                }
            }

            return result;
        }
    }
}
