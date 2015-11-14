namespace LeetCode
{
    public class _027_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            var index = 0;
            var lastIndex = nums.Length - 1;
            var temp = 0;

            while (index <= lastIndex)
            {
                if (nums[index] == val)
                {
                    temp = nums[lastIndex];
                    nums[lastIndex] = val;
                    nums[index] = temp;
                    lastIndex--;
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
