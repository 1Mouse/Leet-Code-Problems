/* this problem should be medium, it is similar to Daily temprature problem

Key observation:
Suppose we have a decreasing sequence followed by a greater number
For example [5, 4, 3, 2, 1, 6] then the greater number 6 is the next greater element for all previous numbers in the sequence

We use a stack to keep a decreasing sub-sequence, whenever we see a number x greater than stack.peek() we pop all elements less than x and for all the popped ones, their next greater element is x
For example [9, 8, 7, 3, 2, 1, 6]
The stack will first contain [9, 8, 7, 3, 2, 1] and then we see 6 which is greater than 1 so we pop 1 2 3 whose next greater element should be 6
*/

/*
Input: nums1 = [4,1,2], nums2 = [1,3,4,2]
Output: [-1,3,-1]

*/
public class Solution
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var stack = new Stack<int>();
            var map = new Dictionary<int, int>();

            foreach (var num in nums2)
            {
                while(stack.Count!=0 && stack.Peek() < num)
                {
                    map.Add(stack.Pop(), num);
                }

                stack.Push(num);
            }

            // stack values now = {4,2}
            // map values now ={[1,3],[3,4]}
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = map.GetValueOrDefault(nums1[i], -1);
            }

            return nums1;
        }
    }