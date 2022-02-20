var maxDepth = function (root) {
    if (root === undefined || root === null) { //why undefined ??
        return 0;
    }
    return Math.max(maxDepth(root.left), maxDepth(root.right)) + 1;
};
