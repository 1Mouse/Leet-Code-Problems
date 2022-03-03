public class Solution {
    public bool IsSubsequence(string s, string t)
        {
            if(s.Length==0)return true;
            
            for(int i=0,j=0;i<t.Length;i++)
            {
                if (s[j] == t[i])
                    j++;
                if (j == s.Length)
                    return true;
            }
            return false;
        }
}