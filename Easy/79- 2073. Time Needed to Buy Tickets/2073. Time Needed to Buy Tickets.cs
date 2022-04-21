public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k)
        {
            // code could be minimized, but I want it to be understandable and readable
            int total = tickets[k];
            for (int i = 0; i < k; i++)
            {
                if (tickets[i] >= tickets[k])
                    total += tickets[k];
                else if (tickets[i] < tickets[k])
                    total += tickets[i];
            }
            for (int i = k+1; i < tickets.Length; i++)
            {
                if (tickets[i] >= tickets[k])
                    total += tickets[k]-1;
                else if (tickets[i] < tickets[k])
                    total += tickets[i];
            }
            
            return total;
        }
}