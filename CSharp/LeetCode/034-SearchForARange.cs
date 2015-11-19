namespace LeetCode
{
    public class _034_SearchForARange
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int lo = 0, hi = nums.Length, mid = 0;
            while (lo < hi)
            {
                mid = lo + (hi - lo) / 2;

                if (target > nums[mid]) { lo = mid + 1; }
                else { hi = mid; }
            }
            if (lo == nums.Length || nums[lo] != target)
            {
                return new int[] { -1, -1 };
            }

            var result = new int[2];
            result[0] = lo;

            lo = mid; hi = nums.Length; mid = 0;
            while (lo < hi)
            {
                mid = lo + (hi - lo) / 2;

                if (target >= nums[mid]) { lo = mid + 1; }
                else { hi = mid; }
            }
            result[1] = lo - 1;

            return result;
        }
    }
}
