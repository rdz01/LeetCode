using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _085_MaximalRectangle
    {
        public int MaximalRectangle(char[,] matrix)
        {
            var rowLenght = matrix.GetLength(0);
            var columnLenght = matrix.GetLength(1);

            int i = 0, j = 0;
            var height = new int[columnLenght + 1];
            for (i = 0; i < columnLenght; i++)
                height[i] = matrix[0, i] == '1' ? 1 : 0;
            height[i] = 0;

            i = 0;
            int maxArea = 0, topIndex = 0;
            var stack = new Stack<int>();
            while (i++ < rowLenght)
            {
                j = 0;
                while (j < height.Length)
                {
                    if (stack.Count == 0 || height[j] > height[stack.Peek()])
                    {
                        stack.Push(j++);
                        continue;
                    }

                    topIndex = stack.Pop();
                    maxArea = Math.Max(
                        maxArea,
                        height[topIndex] * (stack.Count == 0 ? j : j - stack.Peek() - 1));
                }
                stack.Clear();

                if (i == rowLenght) { return maxArea; }
                for (j = 0; j < columnLenght; j++)
                    height[j] = matrix[i, j] == '1' ? height[j] + 1 : 0;
            }

            return maxArea;
        }
    }
}
