#include "stdafx.h"
#include "CppUnitTest.h"
extern "C" {
#include "..\LeetCode\003-LongestSubstringWithoutRepeatingCharacters.h"
}

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace LeetCodeTest
{
	TEST_CLASS(_003_LongestSubstringWithoutRepeatingCharacters_Test)
	{
	public:

		TEST_METHOD(LengthOfLongestSubstringTest_General)
		{
			char *input = "abcabcbb";

			int result = lengthOfLongestSubstring(input);

			Assert::AreEqual(3, result);
		}

		TEST_METHOD(LengthOfLongestSubstringTest_RepeatChars)
		{
			char *input = "bbbbb";

			int result = lengthOfLongestSubstring(input);

			Assert::AreEqual(1, result);
		}

		TEST_METHOD(LengthOfLongestSubstringTest_EmptyInput)
		{
			char *input = "";

			int result = lengthOfLongestSubstring(input);

			Assert::AreEqual(0, result);
		}

		TEST_METHOD(LengthOfLongestSubstringTest_LongString)
		{
			char *input = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

			int result = lengthOfLongestSubstring(input);

			Assert::AreEqual(26, result);
		}

		TEST_METHOD(LengthOfLongestSubstringTest_LongString_HaveShortRepeat)
		{
			char *input = "abcdefghijklmnopqrstuvwxyzabcdefghijk  lmnopqrstuvwxyz";

			int result = lengthOfLongestSubstring(input);

			Assert::AreEqual(27, result);
		}

	};
}