/**
 * @param {string[]} event1
 * @param {string[]} event2
 * @return {boolean}
 */
var haveConflict = function (event1, event2) {
    const [start1, end1] = event1;
    const [start2, end2] = event2;

    // event1 = ["01:15","02:00"], event2 = ["02:00","03:00"]
    let s1h = parseInt(start1[0] + start1[1]);
    let s1m = parseInt(start1[3] + start1[4]);

    let e1h = parseInt(end1[0] + end1[1]);
    let e1m = parseInt(end1[3] + end1[4]);

    let s2h = parseInt(start2[0] + start2[1]);
    let s2m = parseInt(start2[3] + start2[4]);

    let e2h = parseInt(end2[0] + end2[1]);
    let e2m = parseInt(end2[3] + end2[4]);

    //if event 2 starts after event 1
    if (s2h + s2m > s1h + s2m) { 
        if (s2h > e1h)
            return false
        else if (s2h === e1h && s2m > e1m)
            return false;

        return true;
    }

    //if event 1 starts after event 2
    if (s1h > e2h)
        return false
    else if (s1h === e2h && s1m > e2m)
        return false;

    return true;
};