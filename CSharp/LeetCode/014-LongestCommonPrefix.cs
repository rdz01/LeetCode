using System.Text;

namespace LeetCode
{
    public class _014_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) { return string.Empty; }
            if (strs.Length == 1) { return strs[0]; }

            var result = new StringBuilder();
            bool isSame = true;
            for (int index = 0; index < strs[0].Length; index++)
            {
                for (int i = 1; i < strs.Length; i++)
                {
                    if (strs[i].Length <= index ||
                        strs[i][index] != strs[0][index])
                    {
                        isSame = false;
                        break;
                    }
                }

                if (isSame)
                {
                    result.Append(strs[0][index]);
                }
                else
                {
                    break;
                }
            }

            return result.ToString();
        }
    }
}
