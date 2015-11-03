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

            if (digits.Length == 0) { return new List<string>(); }

            try
            {
                var result = new List<string>() { "" };
                var keyboard = "";
                var index = 0;

                foreach (char digit in digits)
                {
                    keyboard = phoneChars[digit - '0'];
                    if (keyboard.Length == 0) { continue; }

                    for (int j = result.Count - 1; j >= 0; j--)
                    {
                        for (int i = 1; i < keyboard.Length; i++)
                        {
                            result.Insert(j + 1, result[j]);
                        }
                    }

                    index = 0;
                    for (var i = 0; i < result.Count; i++)
                    {
                        result[i] += phoneChars[digit - '0'][index++];
                        if (index == keyboard.Length) { index = 0; }
                    }
                }

                if (result.Count == 1 && result[0] == "") { result.Clear(); }
                return result;
            }
            catch
            {
                return new List<string>();
            }
        }
    }
}
