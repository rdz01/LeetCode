using System;

namespace LeetCode
{
    public class _072_EditDistance
    {
        public int MinDistance(string word1, string word2)
        {
            int size1 = word1.Length + 1, size2 = word2.Length + 1;
            var matrix = new int[size2, size1];

            int i, j;
            for (i = 0; i < size1; i++) { matrix[0, i] = i; }
            for (i = 1; i < size2; i++) { matrix[i, 0] = i; }

            for (i = 1; i < size1; i++)
                for (j = 1; j < size2; j++)
                {
                    if (word1[i - 1] == word2[j - 1]) { matrix[j, i] = matrix[j - 1, i - 1]; }
                    else
                    {
                        matrix[j, i] = Math.Min(matrix[j - 1, i - 1], Math.Min(matrix[j, i - 1], matrix[j - 1, i])) + 1;
                    }
                }

            return matrix[size2 - 1, size1 - 1];
        }
    }
}
