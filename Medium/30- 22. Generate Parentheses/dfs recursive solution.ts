function generateParenthesis(n: number): string[] {
    const allCombos: string[] = []

    function dfs(open: number, close: number, str: string) {
        if (str.length === n * 2) {
            allCombos.push(str)
        }

        if (open > close) {
            dfs(open, close + 1, str + ')')
        }

        if (open < n) {
            dfs(open + 1, close, str + '(')
        }
    }
    dfs(0, 0, '')

    return allCombos
};
