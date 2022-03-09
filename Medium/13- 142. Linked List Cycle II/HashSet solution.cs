/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        var freq = new HashSet<ListNode>();
        ListNode curr = head;
        while (curr != null)
        {
            if (!freq.Contains(curr))
            {
                freq.Add(curr);
            }
            else
            {
                return curr;
            }
            curr = curr.next;
        }
        return null;
    }
}