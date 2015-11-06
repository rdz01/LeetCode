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

            if (nums[0] == nums[nums.Length - 1])
            {
                if (target == nums[0] * 4)
                {
                    results.Add(new List<int>() { nums[0], nums[0], nums[0], nums[0] });
                }
                return results;
            }

            var cache = new Dictionary<int, IList<KeyValuePair<int, int>>>();
            var temp = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    temp = nums[i] + nums[j];
                    if (!cache.ContainsKey(temp))
                    {
                        cache[temp] = new List<KeyValuePair<int, int>>();
                    }
                    cache[temp].Add(new KeyValuePair<int, int>(i, j));
                }
            }

            IList<KeyValuePair<int, int>> list1, list2;
            KeyValuePair<int, int> item1, item2;
            IList<int> result;
            foreach (var pair in cache)
            {
                temp = target - pair.Key;
                if (!cache.ContainsKey(temp)) { continue; }

                list1 = pair.Value;
                list2 = cache[temp];
                for (var index1 = 0; index1 < list1.Count; index1++)
                {
                    item1 = list1[index1];

                    for (var index2 = 0; index2 < list2.Count; index2++)
                    {
                        item2 = list2[index2];

                        if ((item1.Key != item2.Key && item1.Key != item2.Value && item1.Value != item2.Key && item1.Value != item2.Value) &&
                            (item1.Value < item2.Key))
                        {
                            result = new List<int>() { nums[item1.Key], nums[item1.Value], nums[item2.Key], nums[item2.Value] };
                            results.Add(result);
                            while (index2 + 1 < list2.Count && nums[list2[index2 + 1].Key] == nums[list2[index2].Key])
                            {
                                index2++;
                            }
                        }
                    }

                    while (index1 + 1 < list1.Count && nums[list1[index1 + 1].Value] == nums[list1[index1].Value])
                    {
                        index1++;
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