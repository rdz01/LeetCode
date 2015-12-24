using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _078_Subsets
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var results = new List<IList<int>>();
            results.Add(new List<int>());

            if (nums == null || nums.Length == 0) { return results; }

            Array.Sort(nums);
            results.Add(new List<int>(nums));

            int n = nums.Length;
            var select = new bool[n];
            int i, j, count = 0;

            bool hasNext;
            for (int k = 1; k < n; k++)
            {
                for (i = 0; i < k; i++) { select[i] = true; }
                for (; i < n; i++) { select[i] = false; }

                while (true)
                {
                    var result = new List<int>();
                    for (i = 0; i < n; i++)
                        if (select[i]) { result.Add(nums[i]); }
                    results.Add(result);

                    hasNext = false;
                    count = 0;
                    for (i = 0; i < n - 1; i++)
                    {
                        if (select[i] && !select[i + 1])
                        {
                            select[i + 1] = true;
                            select[i] = false;
                            hasNext = true;

                            for (j = 0; j < i; j++)
                                select[j] = count-- > 0 ? true : false;

                            break;
                        }

                        if (select[i]) { count++; }
                    }

                    if (!hasNext) break;
                }
            }

            return results;
        }
    }
}
