// 203. Remove Linked List Elements
// https://leetcode.com/problems/remove-linked-list-elements/


/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* removeElements(ListNode* head, int val) {
        ListNode* afterRemoval=new ListNode();
        ListNode* temp=afterRemoval;
        
        while(head!=NULL)
        {
            if(head->val!=val)
            {
                temp->next=new ListNode(head->val);
                temp=temp->next;
            }
            
            head=head->next;
        }
        
        return afterRemoval->next;
    }
};
