/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        //This copies the value of the next node into node
        node.val=node.next.val;
        //then it skips the next node from the list 
        node.next=node.next.next;

        //that is not real deletion
    }
}