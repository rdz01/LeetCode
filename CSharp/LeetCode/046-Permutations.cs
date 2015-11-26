using System.Collections.Generic;

namespace LeetCode
{
    public class _046_Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            result.Add(new List<int>(nums));

            int length = nums.Length;
            int size, temp, i, j, k;
            IList<int> tempList;
            for (i = 0; i < length; i++)
            {
                size = result.Count;
                for (j = 0; j < size; j++)
                {
                    tempList = new List<int>(result[j]);
                    for (k = i + 1; k < length; k++)
                    {
                        temp = tempList[k];
                        tempList[k] = tempList[i];
                        tempList[i] = temp;
                        result.Add(new List<int>(tempList));
                    }
                }
            }

            return result;
        }
    }
}
