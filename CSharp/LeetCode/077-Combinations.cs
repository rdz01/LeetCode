using System.Collections.Generic;

namespace LeetCode
{
    public class _077_Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            if (n <= 0 || k <= 0 || k > n) { return null; }

            var results = new List<IList<int>>();
            IList<int> result;
            var select = new bool[n];
            int i, j, count = 0;
            bool hasNext;

            for (i = 0; i < k; i++) { select[i] = true; }

            while (true)
            {
                result = new List<int>();
                for (i = 0; i < n; i++)
                    if (select[i]) { result.Add(i + 1); }
                results.Add(result);

                hasNext = false;
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

            return results;
        }
    }
}
