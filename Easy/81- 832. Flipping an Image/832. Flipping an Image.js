/**
 * @param {number[][]} image
 * @return {number[][]}
 */
var flipAndInvertImage = function (image) {
    for (let row of image) {
        let i = 0,
            j = row.length - 1;
        while (i < j) {
            row[i] = row[i] ^ 1; //xor with logic 1 to represent inverter
            row[j] = row[j] ^ 1;
            [row[i], row[j]] = [row[j], row[i]]; //swapping
            ++i;
            --j;
        }
    }
    // to handle odd length rows
    if (image[0].length % 2 === 1) {
        for (let row of image) {
            row[Math.floor(image[0].length / 2)] =
                row[Math.floor(image[0].length / 2)] ^ 1;
        }
    }

    return image;
};
