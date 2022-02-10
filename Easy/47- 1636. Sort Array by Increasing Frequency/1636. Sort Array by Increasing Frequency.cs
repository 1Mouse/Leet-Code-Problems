 public int[] FrequencySort(int[] nums)
        {
            var freq = new Dictionary<int, int>();

            foreach (var i in nums)
            {
                if (freq.ContainsKey(i))
                    freq[i]++;
                else
                    freq.Add(i, 1);
            }
            // 2,3,1,3,2
            //default sort is sorting ascendingly
            // make a lamda function as comparator
            // return -1 to reverse ascendingly --> descendingly
            // return 1 to ascendingly
            Array.Sort(nums, (a, b) =>
             {
                 //------------------
                 // condition 
                 // return
                 // else 
                 // return
                 //-------------------
                 if ((freq[a] == freq[b] && a > b) || freq[a] < freq[b])
                     return -1; 
                 else
                     return 1;

             });
            return nums;
        }