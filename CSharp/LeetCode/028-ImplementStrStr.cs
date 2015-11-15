namespace LeetCode
{
    public class _028_ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            var needleLength = needle.Length;
            if (needleLength == 0) { return 0; }

            var haystackLength = haystack.Length;
            var needleIndex = 0;
            for (int i = 0; i < haystackLength; i++)
            {
                needleIndex = 0;
                while (needleIndex < needleLength
                    && i + needleIndex < haystackLength
                    && haystack[i + needleIndex] == needle[needleIndex])
                {
                    needleIndex++;
                }
                if (needleIndex == needleLength)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
