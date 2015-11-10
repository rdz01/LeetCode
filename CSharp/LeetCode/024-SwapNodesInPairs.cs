namespace LeetCode
{
    public class _024_SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            var dummyHead = new ListNode(-1);
            dummyHead.next = head;
            ListNode p = dummyHead, q;

            while (true)
            {
                if (p.next == null || p.next.next == null) break;

                q = p.next;
                p.next = q.next;
                q.next = p.next.next;
                p.next.next = q;

                p = q;
            }

            return dummyHead.next;
        }


        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
