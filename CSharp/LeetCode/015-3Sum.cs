using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _015_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 3) { return result; }

            Suffle(nums);
            Quick3WaySort(nums, 0, nums.Length - 1);

            int rest = 0;
            for (var lo = 0; lo < nums.Length && nums[lo] <= 0; lo++)
            {
                for (int hi = nums.Length - 1; hi > lo && nums[hi] >= 0; hi--)
                {
                    rest = 0 - nums[lo] - nums[hi];
                    if (rest > nums[hi] || rest < nums[lo]) { continue; }

                    var restIndex = BinarySearch(nums, lo + 1, hi - 1, rest);
                    if (restIndex != -1)
                    {
                        result.Add(new List<int>() { nums[lo], rest, nums[hi] });
                    }

                    while (hi - 1 > lo && nums[hi - 1] == nums[hi])
                    {
                        hi--;
                    }
                }

                while (lo + 1 < nums.Length && nums[lo + 1] == nums[lo])
                {
                    lo++;
                }
            }

            return result;
        }

        int BinarySearch(int[] nums, int lo, int hi, int target)
        {
            int mid;
            while (lo <= hi)
            {
                mid = lo + (hi - lo) / 2;

                if (target > nums[mid])
                {
                    while (mid + 1 <= hi && nums[mid + 1] == nums[mid])
                    {
                        mid++;
                    }
                    lo = mid + 1;
                }
                else if (target < nums[mid])
                {
                    while (mid - 1 >= lo && nums[mid - 1] == nums[mid])
                    {
                        mid--;
                    }
                    hi = mid - 1;
                }
                else
                {
                    return mid;
                }

            }
            return -1;
        }

        void Suffle(int[] a)
        {
            var random = new Random();
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                int r = random.Next(i + 1);
                Exchange(a, r, i);
            }
        }

        void Quick3WaySort(int[] nums, int lo, int hi)
        {
            if (lo >= hi) { return; }
            var lt = lo;
            var gt = hi;
            var i = lo;
            var v = nums[i];

            while (i <= gt)
            {
                if (nums[i] > v) { Exchange(nums, i, gt--); }
                else if (nums[i] < v) { Exchange(nums, i++, lt++); }
                else { i++; }
            }
            Quick3WaySort(nums, lo, lt - 1);
            Quick3WaySort(nums, gt + 1, hi);
        }

        void Exchange(int[] nums, int x, int y)
        {
            int temp = nums[x];
            nums[x] = nums[y];
            nums[y] = temp;
        }
    }
}
