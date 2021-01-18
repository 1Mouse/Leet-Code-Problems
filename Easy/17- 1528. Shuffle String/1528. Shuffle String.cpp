class Solution {
public:
    string restoreString(string s, vector<int>& indices) {
        string new_S=s;
        for(int i=0;i<s.size();i++)
        {
            new_S[ indices[i]]=s[i];
        }
        return new_S;
    }
};