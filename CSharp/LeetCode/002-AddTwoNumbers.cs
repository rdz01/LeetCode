﻿namespace LeetCode
{
    public class _002_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var first = new ListNode(-1);
            first.next = new ListNode(0);
            var current = first;

            while (l1 != null || l2 != null)
            {
                var value1 = l1 == null ? 0 : l1.val;
                var value2 = l2 == null ? 0 : l2.val;

                current = current.next;
                var sum = value1 + value2 + current.val;

                if (sum >= 10)
                {
                    current.val = sum % 10;
                    current.next = new ListNode(1);
                }
                else
                {
                    current.val = sum;
                    current.next = new ListNode(0);
                }

                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }

            if (current.next.val == 0)
            {
                current.next = null;
            }

            return first.next;
        }
    }
}
