namespace LeetCode
{
    public class _075_SortColors
    {
        public void SortColors(int[] nums)
        {
            int lt = 0, gt = nums.Length - 1, i = 0, temp;
            while (i <= gt)
            {
                if (nums[i] == 0)
                {
                    temp = nums[lt];
                    nums[lt++] = nums[i];
                    nums[i++] = temp;
                }
                else if (nums[i] == 2)
                {
                    nums[i] = nums[gt];
                    nums[gt--] = 2;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
