using System.Collections.Generic;

namespace LeetCode
{
    public class _020_ValidParentheses
    {
        public bool IsValid(string s)
        {
            var list = new List<char>();
            var index = -1;
            char ch, lastCh;

            for (int i = 0; i < s.Length; i++)
            {
                ch = s[i];
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    list.Add(ch);
                    index++;
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (index < 0) { return false; }
                    lastCh = list[index];
                    if ((ch == ')' && lastCh == '(') ||
                        (ch == ']' && lastCh == '[') ||
                        (ch == '}' && lastCh == '{'))
                    {
                        list.RemoveAt(index--);
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
