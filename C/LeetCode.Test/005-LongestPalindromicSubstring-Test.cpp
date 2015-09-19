#include "stdafx.h"
#include "CppUnitTest.h"
extern "C" {
#include "..\LeetCode\005-LongestPalindromicSubstring.h"
}

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace LeetCodeTest
{
	TEST_CLASS(_005_LongestPalindromicSubstring_Test)
	{
	public:

		TEST_METHOD(LongestPalindromeTest_Odd)
		{
			char *input = "abcdefgfedcba";

			char *result = longestPalindrome(input);

			Assert::AreEqual("abcdefgfedcba", result);
		}

		TEST_METHOD(LongestPalindromeTest_Even)
		{
			char *input = "abcdefggfedcba";

			char *result = longestPalindrome(input);

			Assert::AreEqual("abcdefggfedcba", result);
		}

		TEST_METHOD(LongestPalindromeTest_AllTheSame_Odd)
		{
			char *input = "ccc";

			char *result = longestPalindrome(input);

			Assert::AreEqual("ccc", result);
		}

		TEST_METHOD(LongestPalindromeTest_AllTheSame_Even)
		{
			char *input = "aaaaaaaaaa";

			char *result = longestPalindrome(input);

			Assert::AreEqual("aaaaaaaaaa", result);
		}

		TEST_METHOD(LongestPalindromeTest_EmptyString)
		{
			char *input = "";

			char *result = longestPalindrome(input);

			Assert::AreEqual("", result);
		}

		TEST_METHOD(LongestPalindromeTest_OneCharacterString)
		{
			char *input = "a";

			char *result = longestPalindrome(input);

			Assert::AreEqual("a", result);
		}

		TEST_METHOD(LongestPalindromeTest_LongestAtStart)
		{
			char *input = "aabccdccbaaeeggee";

			char *result = longestPalindrome(input);

			Assert::AreEqual("aabccdccbaa", result);
		}

		TEST_METHOD(LongestPalindromeTest_LongestAtEnd)
		{
			char *input = "eegffgeeaabcdcbaa";

			char *result = longestPalindrome(input);

			Assert::AreEqual("aabcdcbaa", result);
		}

		TEST_METHOD(LongestPalindromeTest_MultipleMixPalindrome) {
			char *input = "abcdcbbcd";

			char *result = longestPalindrome(input);

			Assert::AreEqual("dcbbcd", result);
		}

		TEST_METHOD(LongestPalindromeTest_MultipleMixPalindrome_2) {
			char *input = "abcddcbebcd";

			char *result = longestPalindrome(input);

			Assert::AreEqual("dcbebcd", result);
		}
	};
}