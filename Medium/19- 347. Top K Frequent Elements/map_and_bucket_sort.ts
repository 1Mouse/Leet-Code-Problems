// O(n), O(n)
function topKFrequent(nums: number[], k: number): number[] {
    const freqMap = new Map<number, number>();

    // track number of occurrences for each value
    nums.forEach(n => {
        freqMap.set(n, freqMap.has(n) ? freqMap.get(n)! + 1 : 1)
    })

    let result: number[] = []
    let bucket: Array<Array<number>> = []

    for (const [key, value] of freqMap.entries()) {
        //to avoid intializing the whole array. we init on demand
        if (bucket[value] === undefined) {
            bucket[value] = []
        }

        bucket[value].push(key)
    }

    for (let i = bucket.length; i >= 0; i--) {
        if (bucket[i] && bucket[i].length > 0) {
            for (let n of bucket[i]) {
                result.push(n);
                if (result.length === k)
                    return result;
            }
        }
    }

    return result
};
