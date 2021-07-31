public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {

        int numOfValidStrings = 0;
        foreach (var word in words)
        {
            int countValidCharacters = 0;
            for (int i = 0; i < word.Length; i++)
            {
                countValidCharacters = allowed.Contains(word[i]) ? ++countValidCharacters : countValidCharacters;
            }
            numOfValidStrings = countValidCharacters == word.Length ? ++numOfValidStrings : numOfValidStrings;
        }

        return numOfValidStrings;
    }
}