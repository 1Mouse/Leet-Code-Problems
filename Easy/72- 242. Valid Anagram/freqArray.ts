function isAnagram(s: string, t: string): boolean {
    const freq:Array<number>= new Array(26).fill(0)
  
    if (s.length!==t.length)
    return false;


    for(let i=0;i<s.length;i++){
        freq[calcHashedIndex(s[i])]++;
        freq[calcHashedIndex(t[i])]--;
    }

    for(const entry of freq){
        if(entry!==0)
        return false
    }

    return true
};


function calcHashedIndex(c:string){
    return c.charCodeAt(0)-97
}
