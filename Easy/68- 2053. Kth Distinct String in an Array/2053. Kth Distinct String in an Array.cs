public class Solution
{
    public string KthDistinct(string[] arr, int k)
    {
        var freq = new Dictionary<string, int>();
        foreach (string word in arr)
        {
            if (freq.ContainsKey(word))
            {
                freq[word]++;
            }
            else
            {
                freq.Add(word, 1);
            }
        }
        int counter = 0;
        foreach (var item in freq)
        {
            if (item.Value == 1) counter++;
            if (counter == k) return item.Key;
        }
        return "";
    }
}