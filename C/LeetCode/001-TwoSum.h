#pragma once
#include "common.h"
#include <stdlib.h>

using namespace std;

class LEETCODE_API _001_TwoSum
{
public:
	_001_TwoSum();
	~_001_TwoSum();

	/**
	* Note: The returned array must be malloced, assume caller calls free().
	*/
	int* twoSum(int* nums, int numsSize, int target);
};

