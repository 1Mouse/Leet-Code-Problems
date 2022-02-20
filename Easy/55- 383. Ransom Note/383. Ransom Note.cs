public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
            return false;

        var map = new Dictionary<char, int>();

        foreach (char c in ransomNote)
        {
            if (map.ContainsKey(c))
                map[c]++;
            else
                map.Add(c, 1);
        }
        foreach (var c in magazine)
        {
            if (map.ContainsKey(c))
                map[c]--;
            else
                map.Add(c, -1);
        }

        foreach (var item in map)
        {
            if (item.Value > 0)
                return false;
        }
        return true;
    }
}