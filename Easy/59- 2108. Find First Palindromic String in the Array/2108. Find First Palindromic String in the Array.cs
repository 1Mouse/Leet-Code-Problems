public class Solution {
    public string FirstPalindrome(string[] words)
        {
            foreach (var word in words)
            {
                int validPalindrome = 0;
                int pointer1 = 0, pointer2 = word.Length - 1;
                while (pointer1 < pointer2)
                {
                    if (word[pointer1] == word[pointer2])
                        validPalindrome++;
                    else
                        break;

                    pointer1++; pointer2--;
                }
                
                if (validPalindrome == word.Length / 2)
                    return word;
            }
            return "";
        }
}