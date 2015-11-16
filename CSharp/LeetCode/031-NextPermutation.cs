using System;

namespace LeetCode
{
    public class _031_NextPermutation
    {
        public void NextPermutation(int[] nums)
        {
            int i;
            for (i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i - 1] < nums[i])
                {
                    break;
                }
            }
            if (i <= 0)
            {
                Array.Reverse(nums);
                return;
            }

            int j = nums.Length - 1;
            while (j >= 0 && nums[j] <= nums[i - 1])
            {
                j--;
            }

            int temp = nums[j];
            nums[j] = nums[i - 1];
            nums[i - 1] = temp;

            Array.Reverse(nums, i, nums.Length - i);
        }
    }
}
