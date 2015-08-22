#include "stdafx.h"
#include "CppUnitTest.h"
#include "..\LeetCode\_001_TwoSum.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace LeetCodeTest
{
	TEST_CLASS(_001_TwoSum_Test)
	{
	public:

		TEST_METHOD(TwoSumTest_Ordered)
		{
			vector<int> nums = { 2,7,11,15 };
			int target = 9;

			_001_TwoSum solution;
			vector<int> result = solution.twoSum(nums, target);

			Assert::AreEqual(2, (int)result.size());
			Assert::AreEqual(1, result[0]);
			Assert::AreEqual(2, result[1]);
		}

	};
}