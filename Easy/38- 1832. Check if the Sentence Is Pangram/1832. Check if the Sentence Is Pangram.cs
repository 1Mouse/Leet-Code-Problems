public class Solution {
    public bool CheckIfPangram(string sentence) {

        HashSet<char> map = new HashSet<char>();

        // a HashSet doesn't contain duplicates
        for (int i = 0; i < sentence.Length; i++)
            {
                    map.Add(sentence[i]);

            }

            return (map.Count == 26) ? true : false;
    }
}