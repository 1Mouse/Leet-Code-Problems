function intersection(nums1: number[], nums2: number[]): number[] {
    const set1=new Set(nums1)
    const set2= new Set(nums2)

   const commonElements=[] 
    for(const element of set1){
        if(set2.has(element))
            commonElements.push(element)
    }

    return commonElements
};
