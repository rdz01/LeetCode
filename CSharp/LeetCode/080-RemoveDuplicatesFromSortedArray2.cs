namespace LeetCode
{
    public class _080_RemoveDuplicatesFromSortedArray2
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2) { return nums.Length; }

            var index = 2;
            for (int i = 2; i < nums.Length; i++)
                if (nums[i] != nums[index - 2])
                    nums[index++] = nums[i];

            return index;
        }
    }
}
