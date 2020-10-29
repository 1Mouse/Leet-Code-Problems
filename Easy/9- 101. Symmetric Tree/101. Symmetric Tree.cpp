/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
     
    class Solution {
public:
bool isSymmetric(TreeNode* root) 
{
	if(!root) return true;
	queue<TreeNode*> q;
	q.push(root);
	while(!q.empty())
	{
		int bfs = q.size();
		vector<int> vtn;

		for(int i = 0; i < bfs; i++)
		{
			TreeNode* node = q.front();
			q.pop();

			if(node->left) 
			{
				q.push(node->left);
				vtn.push_back(node->left->val);
			}
			else
			{
				vtn.push_back(-1);
			}

			if(node->right)
			{
				q.push(node->right);
				vtn.push_back(node->right->val);
			}
			else
			{
				vtn.push_back(-1);
			}
		}

		int size = vtn.size();
		for(int i = 0, j = size-1; i < size/2; i++, j--)
		{
			if(vtn[i] != vtn[j])
				return false;
		}
	}
	return true;
}
 };