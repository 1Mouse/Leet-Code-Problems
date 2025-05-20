//Time Complexity: O(n*k)
//Space Complexity: O(n*k)
//n is the number of strings in the strs array
//k is the length of the longest string in the strs array

function groupAnagrams(strs: string[]): string[][] {
    // key is the hashed frequency of the string 
    // value is the index of the string in the strs array
    const hashedFreqMap=new Map<string, number[]>()

    for(let i=0;i<strs.length;i++){
        const hashedFreq= createHashedFreq(strs[i])
        if(hashedFreqMap.has(hashedFreq)){
            hashedFreqMap.get(hashedFreq)?.push(i)
        }else{
            hashedFreqMap.set(hashedFreq, [i])
        }
    }

    const result:string[][]=[]
    for(const indexes of hashedFreqMap.values()){
        result.push(indexes.map(i=>strs[i]))
    }

    return result
};


function createHashedFreq(str:string):string{
    const freq:Array<number>= new Array(26).fill(0)

    for(let i=0;i<str.length;i++){
        const char=str[i]
        const charIndex= char.charCodeAt(0)-'a'.charCodeAt(0)
        freq[charIndex]++
    }
 
    return freq.join(',')
}

