﻿namespace LeetCode
{
    public class _032_LongestValidParentheses
    {
        public int LongestValidParentheses(string s)
        {
            int maxLen = 0, lastError = -1, depth = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(') { depth++; }
                else
                {
                    depth--;
                    if (depth < 0)
                    {
                        depth = 0;
                        lastError = i;
                    }
                    else if (depth == 0)
                    {
                        maxLen = maxLen < i - lastError ? i - lastError : maxLen;
                    }
                }
            }

            lastError = s.Length;
            depth = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ')') { depth++; }
                else
                {
                    depth--;
                    if (depth < 0)
                    {
                        depth = 0;
                        lastError = i;
                    }
                    else if (depth == 0)
                    {
                        maxLen = maxLen < lastError - i ? lastError - i : maxLen;
                    }
                }
            }

            return maxLen;
        }
    }
}
