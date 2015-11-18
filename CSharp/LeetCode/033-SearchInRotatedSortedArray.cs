namespace LeetCode
{
    public class _033_SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int lo = 0, hi = nums.Length - 1;
            int mid;

            while (lo <= hi)
            {
                if (nums[lo] <= nums[hi] && (target < nums[lo] || target > nums[hi]))
                {
                    return -1;
                }

                mid = lo + (hi - lo) / 2;
                if (target == nums[mid]) { return mid; }

                if (nums[lo] <= nums[mid])
                {
                    if (nums[lo] <= target && target < nums[mid])
                    {
                        hi = mid - 1;
                    }
                    else
                    {
                        lo = mid + 1;
                    }
                }
                else
                {
                    if (target <= nums[hi] && nums[mid] < target)
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}
