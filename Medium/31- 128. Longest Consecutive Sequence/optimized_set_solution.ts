//O(N) space and time

function longestConsecutive(nums: number[]): number {
    let mySet = new Set(nums);
    let maxLen = 0;
    for(let num of mySet){
        // check its start of the sequence
        if(!mySet.has(num-1)){
            let len = 0;
            while(mySet.has(num+len)){
                len++
            }
            maxLen = Math.max(maxLen, len);
        }
    }

    return maxLen;
};
