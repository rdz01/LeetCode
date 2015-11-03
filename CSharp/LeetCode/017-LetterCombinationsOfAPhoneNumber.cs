using System.Collections.Generic;

namespace LeetCode
{
    public class _017_LetterCombinationsOfAPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            string[] phoneChars = new string[] { " ",
                                                 "",
                                                 "abc",
                                                 "def",
                                                 "ghi",
                                                 "jkl",
                                                 "mno",
                                                 "pqrs",
                                                 "tuv",
                                                 "wxyz"
                                               };

            var result = new List<string>();
            if (string.IsNullOrWhiteSpace(digits)) { return result; }

            var digit = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                digit = digits[i] - '0';
                if (digit < 0 || digit > 9) { return new List<string>(); }

                if (digit == 1) { continue; }

                if (result.Count == 0)
                {
                    for (int j = 0; j < phoneChars[digit].Length; j++)
                    {
                        result.Add(new string(phoneChars[digit][j], 1));
                    }
                    continue;
                }

                var tempResult = new List<string>();
                for (int j = 0; j < result.Count; j++)
                {
                    for (int k = 0; k < phoneChars[digit].Length; k++)
                    {
                        tempResult.Add(result[j] + phoneChars[digit][k]);
                    }
                }

                result = tempResult;
            }

            return result;
        }
    }
}
