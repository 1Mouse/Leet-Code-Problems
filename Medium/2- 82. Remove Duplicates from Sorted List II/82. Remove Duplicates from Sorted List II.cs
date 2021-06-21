/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        //sentinel head+ previous technique
        ListNode sentinel = new ListNode(0, head);
        ListNode prev = sentinel;

        while (head != null)
        {
            if (head.next != null && head.val == head.next.val)
            {
                while (head.next != null && head.val == head.next.val)
                {
                    head = head.next;
                }

                prev.next = head.next;
            }
            else
            {
                prev = prev.next;
            }

            head = head.next;
        }
        return sentinel.next;
    }
}