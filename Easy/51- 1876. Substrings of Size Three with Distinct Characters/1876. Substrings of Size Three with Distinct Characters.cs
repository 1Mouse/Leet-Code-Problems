public class Solution
{
    public int CountGoodSubstrings(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length - 2; i++)
        {
            if (s[i] != s[i + 1] && s[i] != s[i + 2] && s[i + 1] != s[i + 2])
                count++;
        }
        return count;
    }
}