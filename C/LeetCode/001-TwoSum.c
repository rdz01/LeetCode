#include "001-TwoSum.h"

int *keys;
int *values;

int hash(int key, int size)
{
	return (key & 0x7FFFFFFF) % size;
}

void initialize(int size)
{
	int i;

	keys = (int *)malloc(sizeof(int) * size);
	for (i = 0; i < size; i++)
	{
		keys[i] = -1;
	}

	values = (int *)malloc(sizeof(int) * size);
}

void clear()
{
	free(keys);
	free(values);
}

void put(int key, int value, int size)
{
	int i;
	for (i = hash(key, size); keys[i] != -1; i = (i + 1) % size)
	{
		if (keys[i] == key) {
			values[i] = value;
			return;
		}
	}
	keys[i] = key;
	values[i] = value;
}

int get(int key, int size)
{
	int i;
	for (i = hash(key, size); keys[i] != -1; i = (i + 1) % size)
	{
		if (keys[i] == key) {
			return values[i];
		}
	}
	return -1;
}

int *twoSum(int *nums, int numsSize, int target)
{
	int i;
	int *result = (int *)malloc(sizeof(int) * 2);
	result[0] = result[1] = 0;
	
	initialize(numsSize);

	for (i = 0; i < numsSize; i++)
	{
		if (get(nums[i], numsSize) == -1)
		{
			put(target - nums[i], i, numsSize);
		}
		else
		{
			result[0] = get(nums[i], numsSize) + 1;
			result[1] = i + 1;
			break;
		}
	}

	clear();
	return result;
}