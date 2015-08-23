#ifndef _002_AddTwoNumbers
#define _002_AddTwoNumbers

#include <stdlib.h>

struct ListNode {
	int val;
	struct ListNode *next;
};

struct ListNode *addTwoNumbers(struct ListNode *l1, struct ListNode *l2);

#endif // _002_AddTwoNumbers
