public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        var uniqueEmails = new HashSet<string>();
        foreach (var email in emails)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            for (; email[i] != '@'; i++)
            {
                if (email[i] == '+')
                    break;
                else if (email[i] == '.')
                    continue;
                else
                    sb.Append(email[i]);
            }

            for (; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    break;
                }
            }
            sb.Append(email.Substring(i));

            //string cleaned = sb.ToString();
            uniqueEmails.Add(sb.ToString());
        }
        return uniqueEmails.Count;
    }
}