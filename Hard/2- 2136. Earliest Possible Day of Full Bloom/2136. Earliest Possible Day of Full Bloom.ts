// https://leetcode.com/problems/earliest-possible-day-of-full-bloom/solutions/2754093/js-suspiciously-simple-solution-some-explanation/?orderBy=most_votes&languageTags=javascript
function earliestFullBloom(plantTime: number[], growTime: number[]): number {
    let times: number[][] = [];
    for (let i = 0; i < plantTime.length; i++)
        times.push([plantTime[i], growTime[i]]);

    times.sort((a, b) => b[1] - a[1]); //to sort descendingly based on grow time

    let sumOfplantTime = 0, sumOfBloomTime = 0; //bloom time= plant + grow
    for (let [pTime, gTime] of times) {
        sumOfplantTime += pTime;
        sumOfBloomTime = Math.max(sumOfBloomTime, sumOfplantTime + gTime);
    }

    return sumOfBloomTime;
};