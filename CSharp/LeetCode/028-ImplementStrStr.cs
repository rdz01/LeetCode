namespace LeetCode
{
    public class _028_ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            var needleLength = needle.Length;
            if (needleLength == 0) { return 0; }

            var haystackLength = haystack.Length;
            int i, j;
            if (needleLength == 1)
            {
                for (i = 0; i < haystackLength; i++)
                {
                    if (haystack[i] == needle[0]) { return i; }
                }

                return -1;
            }

            var partialMatchTable = new int[needleLength];
            partialMatchTable[0] = -1;
            partialMatchTable[1] = 0;
            i = 2; j = 0;
            while (i < needleLength)
            {
                if (needle[i - 1] == needle[j])
                {
                    partialMatchTable[i++] = ++j;
                }
                else if (j > 0)
                {
                    j = partialMatchTable[j];
                }
                else
                {
                    partialMatchTable[i++] = 0;
                }
            }

            i = 0; j = 0;
            while (i + j < haystackLength)
            {
                if (needle[j] == haystack[i + j])
                {
                    if (j == needleLength - 1) { return i; }
                    j++;
                }
                else
                {
                    if (partialMatchTable[j] > -1)
                    {
                        i = i + j - partialMatchTable[j];
                        j = partialMatchTable[j];
                    }
                    else
                    {
                        j = 0;
                        i++;
                    }
                }
            }

            return -1;
        }
    }
}
