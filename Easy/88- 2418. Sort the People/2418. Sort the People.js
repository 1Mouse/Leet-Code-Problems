var sortPeople = function (names, heights) {
    let map = new Map();
    for (let i = 0; i < names.length; i++) {
        map.set(heights[i], names[i]);
    }
    heights.sort((a, b) => b - a);
    for (let i = 0; i < names.length; i++) {
        names[i] = map.get(heights[i]);
    }
    return names;
};