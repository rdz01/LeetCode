namespace LeetCode
{
    public class _013_RomanToInteger
    {
        public int RomanToInt(string s)
        {
            string[] symbol = { "MMM", "MM", "M", "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C", "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X", "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };
            int[] value = { 3000, 2000, 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var index = 0;
            var strIndex = 0;
            var result = 0;
            while (strIndex < s.Length)
            {
                if (s.IndexOf(symbol[index], strIndex) == strIndex)
                {
                    strIndex += symbol[index].Length;
                    result += value[index];
                }
                index++;
            }

            return result;
        }
    }
}
