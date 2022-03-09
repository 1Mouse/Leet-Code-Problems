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
    // O(n) time, O(n) space
    public bool HasCycle(ListNode head)
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
                return true;
            }
            curr = curr.next;
        }
        return false;
    }
}