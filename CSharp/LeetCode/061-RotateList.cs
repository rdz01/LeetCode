namespace LeetCode
{
    public class _061_RotateList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (k <= 0 || head == null) { return head; }

            var tempHead = new ListNode(-1);
            tempHead.next = head;

            ListNode i = tempHead, j = tempHead;
            int lenght = 0;
            while (k-- > 0)
            {
                if (i.next != null)
                {
                    i = i.next;
                    lenght++;
                }
                else
                {
                    i = head;
                    k = k % lenght;
                }
            }

            if (i.next == null) { return head; }

            while (i.next != null)
            {
                i = i.next;
                j = j.next;
            }

            i.next = head;
            tempHead.next = j.next;
            j.next = null;
            return tempHead.next;
        }


        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
