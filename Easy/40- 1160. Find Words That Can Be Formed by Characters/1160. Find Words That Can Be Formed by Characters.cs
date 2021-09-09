public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        var frequency = new Dictionary<char, int>();
        foreach (var c in chars)
        {
            if (!frequency.ContainsKey(c))
                frequency.Add(c, 1);
            else
                frequency[c]++;
        }

        int result = 0;
        foreach (var word in words)
        {
            bool flag = true;
            var frequencyCompare = new Dictionary<char, int>();
            foreach (var c in word)
            {
                if (!frequencyCompare.ContainsKey(c))
                    frequencyCompare.Add(c, 1);
                else
                    frequencyCompare[c]++;

                if (!frequency.ContainsKey(c) || frequencyCompare[c] > frequency[c])
                {
                    flag = false;
                    break;
                }
            }
            result = (flag) ? result += word.Length : result;
        }
        return result;
    }
}