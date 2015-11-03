using System.Collections.Generic;

namespace LeetCode
{
    public class _017_LetterCombinationsOfAPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            char[][] phoneChars = new char[][] { new char[] {' ',  '\0', '\0', '\0' },
                                                 new char[] {'\0', '\0', '\0', '\0' },
                                                 new char[] {'a',  'b',  'c',  '\0' },
                                                 new char[] {'d',  'e',  'f',  '\0' },
                                                 new char[] {'g',  'h',  'i',  '\0' },
                                                 new char[] {'j',  'k',  'l',  '\0' },
                                                 new char[] {'m',  'n',  'o',  '\0' },
                                                 new char[] {'p',  'q',  'r',  's'  },
                                                 new char[] {'t',  'u',  'v',  '\0' },
                                                 new char[] {'w',  'x',  'y',  'z'  }
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
                    for (int j = 0; j < 4 && phoneChars[digit][j] != '\0'; j++)
                    {
                        result.Add(new string(phoneChars[digit][j], 1));
                    }
                    continue;
                }

                var tempResult = new List<string>();
                for (int j = 0; j < result.Count; j++)
                {
                    for (int k = 0; k < 4 && phoneChars[digit][k] != '\0'; k++)
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
