using System.Collections.Generic;

namespace LeetCode
{
    public class _039_CombinationSum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            ThreeWayQuickSort(candidates, 0, candidates.Length - 1);

            var result = new List<IList<int>>();
            DeepFirstSearch(candidates, target, 0, new List<int>(), result);
            return result;
        }

        void DeepFirstSearch(int[] candidates, int gap, int startIndex, IList<int> tempResult, IList<IList<int>> result)
        {
            for (int i = startIndex; i < candidates.Length; i++)
            {
                if (candidates[i] > gap) { return; }

                tempResult.Add(candidates[i]);

                if (candidates[i] == gap)
                {
                    result.Add(new List<int>(tempResult));
                }
                else
                {
                    DeepFirstSearch(candidates, gap - candidates[i], i, tempResult, result);
                }
                tempResult.RemoveAt(tempResult.Count - 1);
            }
        }

        void ThreeWayQuickSort(int[] nums, int lo, int hi)
        {
            if (hi <= lo) { return; }
            int i = lo, lt = lo, gt = hi;
            int v = nums[lo];
            int temp;
            while (i <= gt)
            {
                if (nums[i] < v)
                {
                    temp = nums[i];
                    nums[i] = nums[lt];
                    nums[lt] = temp;
                    i++;
                    lt++;
                }
                else if (nums[i] > v)
                {
                    temp = nums[i];
                    nums[i] = nums[gt];
                    nums[gt] = temp;
                    gt--;
                }
                else { i++; }
            }
            ThreeWayQuickSort(nums, lo, lt - 1);
            ThreeWayQuickSort(nums, gt + 1, hi);
        }
    }
}
