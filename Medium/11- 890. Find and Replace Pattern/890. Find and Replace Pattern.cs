// https://leetcode.com/problems/find-and-replace-pattern/
public class Solution {
            public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var answer = new List<string>();
            foreach (var word in words)
            {
                if (matchs(word, pattern))
                    answer.Add(word);
            }
            return answer;
        }
        private bool matchs(string word, string pattern)
        {
            char[] patternToWord = new char[26];
            char[] wordToPattern = new char[26];

            for (int i = 0; i < word.Length; i++)
            {
                if (patternToWord[pattern[i] - 'a'] == 0)
                    patternToWord[pattern[i] - 'a'] = word[i];

                if (wordToPattern[word[i] - 'a'] == 0)
                    wordToPattern[word[i] - 'a'] = pattern[i];

                if (patternToWord[pattern[i] - 'a'] != word[i] || wordToPattern[word[i] - 'a'] != pattern[i])
                {
                    return false;
                }
            }
            return true;
        }
}