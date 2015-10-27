namespace LeetCode
{
    public class _008_StringToInteger
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) { return 0; }

            var sign = 1;
            var index = 0;

            while (index < str.Length && str[index] == ' ') { index++; }

            if (str[index] == '-')
            {
                sign = -1;
                index++;
            }
            else if (str[index] == '+')
            {
                index++;
            }

            var positiveOverflowHead = int.MaxValue / 10;
            var positiveOverflowTail = int.MaxValue % 10;

            var result = 0;
            for (; index < str.Length; index++)
            {
                var ch = str[index];
                if (ch < '0' || ch > '9') { break; }

                if (result > positiveOverflowHead ||
                    (result == positiveOverflowHead && ch - '0' > positiveOverflowTail))
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }

                result = result * 10 + (ch - '0');
            }

            return result * sign;
        }
    }
}
