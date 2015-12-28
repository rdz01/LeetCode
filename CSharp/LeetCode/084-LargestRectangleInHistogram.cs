using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _084_LargestRectangleInHistogram
    {
        public int LargestRectangleArea(int[] height)
        {
            var stack = new Stack<int>();
            int i = 0, maxArea = 0, topIndex = 0;

            while (i < height.Length)
            {
                if (stack.Count == 0 || height[i] > height[stack.Peek()])
                {
                    stack.Push(i++);
                    continue;
                }

                topIndex = stack.Pop();
                maxArea = Math.Max(
                    maxArea,
                    height[topIndex] * (stack.Count == 0 ? i : i - stack.Peek() - 1));
            }

            while (stack.Count != 0)
            {
                topIndex = stack.Pop();
                maxArea = Math.Max(
                    maxArea,
                    height[topIndex] * (stack.Count == 0 ? i : i - stack.Peek() - 1));
            }

            return maxArea;
        }
    }
}
