namespace LeetCode
{
    public class _031_NextPermutation
    {
        public void NextPermutation(int[] nums)
        {
            int j, k, temp;
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i - 1] < nums[i])
                {
                    j = nums.Length - 1;
                    while (j >= 0 && nums[j] <= nums[i - 1])
                    {
                        j--;
                    }
                    if (j == -1) { continue; }

                    temp = nums[j];
                    nums[j] = nums[i - 1];
                    nums[i - 1] = temp;

                    j = i;
                    k = nums.Length - 1;
                    while (j <= k)
                    {
                        temp = nums[j];
                        nums[j++] = nums[k];
                        nums[k--] = temp;
                    }

                    return;
                }

                if (i == 1)
                {
                    j = 0;
                    k = nums.Length - 1;
                    while (j <= k)
                    {
                        temp = nums[j];
                        nums[j++] = nums[k];
                        nums[k--] = temp;
                    }
                }
            }
        }
    }
}
