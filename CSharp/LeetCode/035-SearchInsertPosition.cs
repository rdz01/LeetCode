namespace LeetCode
{
    public class _035_SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int lo = 0, hi = nums.Length, mid = 0;

            while (lo < hi)
            {
                mid = lo + (hi - lo) / 2;

                if (target == nums[mid]) { return mid; }
                else if (target > nums[mid]) { lo = mid + 1; }
                else { hi = mid; }
            }

            return lo;
        }
    }
}
