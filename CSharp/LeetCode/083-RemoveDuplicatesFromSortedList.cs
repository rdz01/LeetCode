﻿namespace LeetCode
{
    public class _083_RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) { return null; }

            var p = head;
            while (p.next != null)
            {
                if (p.val == p.next.val)
                    p.next = p.next.next;
                else
                    p = p.next;
            }

            return head;
        }
    }
}
