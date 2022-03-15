public class Solution
{
    // O(n) time, O(1) space for the Dictionary  as there are only 26 letters in the alphabet.
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var freq = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (freq.ContainsKey(s[i]))//O(1)
                freq[s[i]]++; //O(1)
            else
            {
                freq.Add(s[i], 1);//O(1)
            }

            if (freq.ContainsKey(t[i]))
                freq[t[i]]--;
            else
            {
                freq.Add(t[i], -1);
            }
        }

        foreach (int value in freq.Values)
        {
            if (value < 0)
                return false;
        }

        return true;
    }
}