#include "stdafx.h"
#include "CppUnitTest.h"
#include "..\LeetCode\001-TwoSum.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace LeetCodeTest
{
	TEST_CLASS(_001_TwoSum_Test)
	{
	public:
		_001_TwoSum_Test() {
			for (int i = 0; i < 20000; i++)
			{
				largeArray[i] = i * 2;
			}
		}

		TEST_METHOD(TwoSumTest_Ordered)
		{
			int nums[4] = { 2, 7, 11, 15 };
			int target = 9;

			_001_TwoSum solution;
			int * result = solution.twoSum(nums, 4, target);

			Assert::AreEqual(1, result[0]);
			Assert::AreEqual(2, result[1]);

			free(result);
		}

		TEST_METHOD(TwoSumTest_Unordered)
		{
			int nums[3] = { 5, 75, 25 };
			int target = 100;

			_001_TwoSum solution;
			int * result = solution.twoSum(nums, 3, target);

			Assert::AreEqual(2, result[0]);
			Assert::AreEqual(3, result[1]);

			free(result);
		}

		TEST_METHOD(TwoSumTest_Duplicate)
		{
			int nums[4] = { 5, 5, 15, 30 };
			int target = 20;

			_001_TwoSum solution;
			int * result = solution.twoSum(nums, 4, target);

			Assert::AreEqual(2, result[0]);
			Assert::AreEqual(3, result[1]);

			free(result);
		}

		TEST_METHOD(TwoSumTest_AllSame)
		{
			int nums[4] = { 5, 5, 5, 5 };
			int target = 10;

			_001_TwoSum solution;
			int * result = solution.twoSum(nums, 4, target);

			Assert::AreEqual(1, result[0]);
			Assert::AreEqual(2, result[1]);

			free(result);
		}

		TEST_METHOD(TwoSumTest_NoTarget)
		{
			int nums[4] = { 2, 7, 11, 15 };
			int target = 5;

			_001_TwoSum solution;
			int * result = solution.twoSum(nums, 4, target);

			Assert::AreEqual(0, result[0]);
			Assert::AreEqual(0, result[1]);

			free(result);
		}

		TEST_METHOD(TwoSumTest_LargeArray)
		{
			int target = 19082;

			_001_TwoSum solution;
			int * result = solution.twoSum(largeArray, 20000, target);

			Assert::AreEqual(4771, result[0]);
			Assert::AreEqual(4772, result[1]);

			free(result);
		}

		TEST_METHOD(TwoSumTest_LargeArray_NoTarget)
		{
			int target = 19081;

			_001_TwoSum solution;
			int * result = solution.twoSum(largeArray, 20000, target);

			Assert::AreEqual(0, result[0]);
			Assert::AreEqual(0, result[1]);

			free(result);
		}

	private:
		int largeArray[20000];
	};
}