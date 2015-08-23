#include "002-AddTwoNumbers.h"

int getValueAndMoveNode(struct ListNode **node)
{
	if (*node == NULL) { return 0; }
	int value = (*node)->val;
	*node = (*node)->next;
	return value;
}

struct ListNode *calculateNext(struct ListNode **node, struct ListNode **l1, struct ListNode **l2)
{
	int value1 = getValueAndMoveNode(l1);
	int value2 = getValueAndMoveNode(l2);

	int sum = value1 + value2 + (*node)->val;

	if (sum >= 10)
	{
		(*node)->val = sum % 10;
		(*node)->next = (struct ListNode *)malloc(sizeof(struct ListNode));
		(*node)->next->val = 1;
		(*node)->next->next = NULL;
	}
	else
	{
		(*node)->val = sum;
		(*node)->next = (struct ListNode *)malloc(sizeof(struct ListNode));
		(*node)->next->val = 0;
		(*node)->next->next = NULL;
	}

	return *node;
}

struct ListNode *addTwoNumbers(struct ListNode *l1, struct ListNode *l2)
{
	struct ListNode *first, *current;
	first = (struct ListNode *)malloc(sizeof(struct ListNode));
	first->val = -1;
	first->next = (struct ListNode *)malloc(sizeof(struct ListNode));
	first->next->val = 0;
	first->next->next = NULL;
	current = first;

	while (l1 != NULL || l2 != NULL)
	{
		current = calculateNext(&(current->next), &l1, &l2);
	}

	if (current->next->val == 0)
	{
		struct ListNode *temp = current->next;
		current->next = NULL;
		free(temp);
	}
	return first->next;
}