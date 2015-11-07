using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _018_4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var results = new List<IList<int>>();
            if (nums.Length < 4) { return results; }

            Suffle(nums);
            Quick3WaySort(nums, 0, nums.Length - 1);

            var cache = new Dictionary<int, IList<int>>();
            var temp = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    temp = nums[i] + nums[j];
                    if (!cache.ContainsKey(temp))
                    {
                        cache[temp] = new List<int>();
                    }
                    cache[temp].Add(i);
                    cache[temp].Add(j);
                }
            }

            IList<int> list1, list2;
            foreach (var pair in cache)
            {
                temp = target - pair.Key;
                if (!cache.ContainsKey(temp)) { continue; }

                list1 = pair.Value;
                list2 = cache[temp];
                for (var index1 = 0; index1 < list1.Count; index1 += 2)
                {
                    for (var index2 = 0; index2 < list2.Count; index2 += 2)
                    {
                        if ((list1[index1] != list2[index2] && list1[index1] != list2[index2 + 1]) &&
                            (list1[index1 + 1] < list2[index2]))
                        {
                            results.Add(new List<int>() { nums[list1[index1]], nums[list1[index1 + 1]], nums[list2[index2]], nums[list2[index2 + 1]] });
                            while (index2 + 2 < list2.Count && nums[list2[index2 + 2]] == nums[list2[index2]])
                            {
                                index2 += 2;
                            }
                        }
                    }

                    while (index1 + 2 < list1.Count && nums[list1[index1 + 3]] == nums[list1[index1 + 1]])
                    {
                        index1 += 2;
                    }
                }
            }

            return results;
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