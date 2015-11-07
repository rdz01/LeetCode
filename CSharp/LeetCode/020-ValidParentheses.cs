using System.Collections.Generic;

namespace LeetCode
{
    public class _020_ValidParentheses
    {
        public bool IsValid(string s)
        {
            var list = new List<char>();
            char ch, lastCh;

            for (int i = 0; i < s.Length; i++)
            {
                ch = s[i];
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    list.Add(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (list.Count <= 0) { return false; }
                    lastCh = list[list.Count - 1];
                    if ((ch == ')' && lastCh == '(') ||
                        (ch == ']' && lastCh == '[') ||
                        (ch == '}' && lastCh == '{'))
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return list.Count == 0;
        }
    }
}
