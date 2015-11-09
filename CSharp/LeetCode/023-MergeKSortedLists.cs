using System.Collections.Generic;

namespace LeetCode
{
    public class _023_MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0) { return null; }

            var result = new List<ListNode>(lists);
            ListNode head1, head2, newHead;
            while (result.Count > 1)
            {
                head1 = result[0];
                head2 = result[1];
                newHead = MergeTwoLists(head1, head2);
                result.RemoveRange(0, 2);
                result.Add(newHead);
            }

            return result[0];
        }


        ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var head = new ListNode(-1);
            var current = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            current.next = l1 == null ? l2 : l1;
            return head.next;
        }


        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
