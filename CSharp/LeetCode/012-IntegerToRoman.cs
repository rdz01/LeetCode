using System.Text;

namespace LeetCode
{
    public class _012_IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            string[] symbol = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] value = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            var result = new StringBuilder();
            var index = 0;
            while (num != 0)
            {
                if (num >= value[index])
                {
                    num -= value[index];
                    result.Append(symbol[index]);
                }
                else
                {
                    index++;
                }
            }

            return result.ToString();
        }
    }
}
