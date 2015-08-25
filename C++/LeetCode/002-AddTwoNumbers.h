#pragma once
#include "common.h"

struct ListNode {
	int val;
	ListNode *next;
	ListNode(int x) : val(x), next(NULL) {}
};

class LEETCODE_API _002_AddTwoNumbers
{
public:
	_002_AddTwoNumbers();
	~_002_AddTwoNumbers();

	ListNode * addTwoNumbers(ListNode *l1, ListNode *l2);
};