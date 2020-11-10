vector<int> sortedSquares(vector<int> &A)
{
    vector<int> result(A.size());
    ssize_t l = 0;
    ssize_t r = A.size();
    ssize_t p = A.size() - 1;

    while (l < r)
    {
        int x = A[l] * A[l];
        int y = A[r - 1] * A[r - 1];

        if (x >= y)
        {
            result[p] = x;
            p--;
            l++;
        }
        else
        {
            result[p] = y;
            p--;
            r--;
        }
    }

    return result;
}