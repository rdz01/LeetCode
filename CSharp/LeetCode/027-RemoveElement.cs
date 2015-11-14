namespace LeetCode
{
    public class _027_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            var index = 0;
            var lastIndex = nums.Length - 1;

            while (index <= lastIndex)
            {
                if (nums[index] == val)
                {
                    nums[index] = nums[lastIndex--];
                }
                else
                {
                    index++;
                }
            }

            return lastIndex + 1;
        }
    }
}
