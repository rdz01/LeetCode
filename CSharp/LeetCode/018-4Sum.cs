using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _018_4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 4) { return result; }

            Suffle(nums);
            Quick3WaySort(nums, 0, nums.Length - 1);

            for (int index = 0; index < nums.Length - 3; index++)
            {
                var rests = ThreeSum(nums, index + 1, target - nums[index]);
                foreach (var rest in rests)
                {
                    rest.Insert(0, nums[index]);
                }
                result.AddRange(rests);

                while (index < nums.Length - 4 && nums[index + 1] == nums[index])
                {
                    index++;
                }
            }

            return result;
        }

        IList<IList<int>> ThreeSum(int[] nums, int startIndex, int target)
        {
            int sumValue = 0;
            int lo = 0, hi = 0;
            var result = new List<IList<int>>();

            for (var index = startIndex; index < nums.Length - 2; index++)
            {
                lo = index + 1;
                hi = nums.Length - 1;

                while (lo < hi)
                {
                    sumValue = nums[index] + nums[lo] + nums[hi];
                    if (sumValue < target)
                    {
                        do
                        {
                            lo++;
                        } while (lo < hi && nums[lo - 1] == nums[lo]);
                    }
                    else if (sumValue > target)
                    {
                        do
                        {
                            hi--;
                        } while (lo < hi && nums[hi + 1] == nums[hi]);
                    }
                    else
                    {
                        result.Add(new List<int>() { nums[index], nums[lo], nums[hi] });
                        do
                        {
                            lo++;
                        } while (lo < hi && nums[lo - 1] == nums[lo]);
                        do
                        {
                            hi--;
                        } while (lo < hi && nums[hi + 1] == nums[hi]);
                    }
                }

                while (index < nums.Length - 3 && nums[index + 1] == nums[index])
                {
                    index++;
                }
            }

            return result;
        }

        void Suffle(int[] nums)
        {
            var random = new Random();
            int N = nums.Length;
            int r, temp;
            for (int i = 0; i < N; i++)
            {
                r = random.Next(i + 1);

                temp = nums[r];
                nums[r] = nums[i];
                nums[i] = temp;
            }
        }

        void Quick3WaySort(int[] nums, int lo, int hi)
        {
            if (lo >= hi) { return; }
            var lt = lo;
            var gt = hi;
            var i = lo;
            var v = nums[i];
            int temp;

            while (i <= gt)
            {
                if (nums[i] > v)
                {
                    temp = nums[i];
                    nums[i] = nums[gt];
                    nums[gt--] = temp;
                }
                else if (nums[i] < v)
                {
                    temp = nums[i];
                    nums[i] = nums[lt];
                    nums[lt++] = temp;
                }
                else { i++; }
            }
            Quick3WaySort(nums, lo, lt - 1);
            Quick3WaySort(nums, gt + 1, hi);
        }
    }
}