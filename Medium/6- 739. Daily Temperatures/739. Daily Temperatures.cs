    public class Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var stack = new Stack<int>();
            int[] arr = new int[temperatures.Length]; // all values are 0 by default

            for (int i = 0;i<temperatures.Length;i++) 
            {
                while (stack.Count != 0 && temperatures[stack.Peek()] < temperatures[i])
                {
                    int idx = stack.Pop();
                    arr[idx] = i - idx;
                }
                stack.Push(i);
            }
            
            return arr;
        }
    }