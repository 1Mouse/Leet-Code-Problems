public class Solution
{
    public bool IsValid(string s)
    {
        //if (s.Length == 1) return false;
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            var lastPushed = stack.FirstOrDefault();
            if ((lastPushed == '{' && s[i] == '}') || (lastPushed == '[' && s[i] == ']') || (lastPushed == '(' && s[i] == ')'))
                stack.Pop();
            else
                stack.Push(s[i]);
        }
        return (stack.Count() == 0) ? true : false;
    }
}