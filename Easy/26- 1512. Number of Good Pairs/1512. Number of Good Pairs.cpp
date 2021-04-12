class Solution
{
public:
    int numIdenticalPairs(vector<int> &nums)
    {
        unordered_map<int, int> m; //Initializing a Hash Table

        for (int i = 0; i < nums.size(); i++) //Iterating through the vector
        {
            //Counting the occurences of a number and storing it in value.
            ++m[nums[i]];
        }
        int good_pairs = 0;
        for (auto i : m) //Using the formula
        {
            int n = i.second; //i.second implies -- value of hash table
            good_pairs += ((n) * (n - 1)) / 2;
        }
        return good_pairs;
    }
};
/* 
approach:
Count how many times each number appears. If a number appears n times, then
n * (n – 1) // 2 good pairs can be made with this number.
times->good pairs
2 -> 1
3 -> 3
4 -> 3+2+1=6
*/