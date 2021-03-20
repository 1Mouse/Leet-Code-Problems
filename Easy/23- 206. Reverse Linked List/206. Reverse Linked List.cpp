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
class Solution
{
public:
    ListNode *reverseList(ListNode *head)
    {
        ListNode *curr = head;
        ListNode *prev = nullptr;
        ListNode *nextTemp = new ListNode();

        while (curr != nullptr)
        {
            nextTemp = curr->next;
            curr->next = prev;
            prev = curr;
            curr = nextTemp;
        }
        return prev;
    }
};
/*
Isolved using 3 pointers technique

(could also be solved by recursion)


1 --> 2 --> 3 --> 4 --> null

==================================================================
ListNode* reverseList(ListNode* head) {
    if (head == nullptr || head->next == nullptr) 
    	return head;
    	
    ListNode* p = reverseList(head->next);
    head->next->next = head;
    head->next = nullptr;
    return p;
}
==================================================================

========================(TRACING)=================================
at 1:
p = rev(2)

at 2:
p = rev(3)

at 3:
p = rev(4)

at 4:
return 4

Back at 3:
p = 4
4->next = 3
3->next = nullptr
return 4->3

Back at 2:
p = 4->3
3->next = 2
2->next = nullptr
return 4->3->2

Back at 1:
p = 4->3->2
2->next = 1
1->next = nullptr
return 4->3->2->1->nullptr



return 4->3->2->1->nullptr
*/