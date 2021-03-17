class Solution
{
public:
    int majorityElement(vector<int> &nums)
    {

        int check = nums.size() / 2;

        for (int i = 0; i < nums.size(); i++)
        {
            int count = 0;
            for (int j = 0; j < nums.size(); j++)
            {
                if (nums[j] == nums[i])
                    count++;
            }

            if (count > check)
            {
                return nums[i];
            }
        }

    }
};