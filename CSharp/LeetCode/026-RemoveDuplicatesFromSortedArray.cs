namespace LeetCode
{
    public class _026_RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1) { return nums.Length; }

            var index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums[index]) { continue; }

                nums[++index] = nums[i];
            }

            return index + 1;
        }
    }
}
