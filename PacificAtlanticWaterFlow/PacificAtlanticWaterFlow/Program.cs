class Solution
{
    int m, n;
    int[][] A;
    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {

        if (heights.Length == 0 || heights == null) return new List<IList<int>>();
        var result = new List<IList<int>>();
        m = heights.Length;
        n = heights[0].Length;
        this.A = heights;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                //find where water can flow to both Pacific and Atlantic
                if (Pacific(i, j) && Atlantic(i, j))
                {
                    result.Add(new List<int>() { i, j });
                }
            }
        }
        return result;
    }

    bool Pacific(int i, int j)
    {

        if (i == 0 || j == 0) return true;
        if (A[i][j] == -1) return false;
        int element = A[i][j];
        A[i][j] = -1;
        bool flows = false;

        if (A[i - 1][j] <= element)
        {
            flows = Pacific(i - 1, j);
        }

        if (!flows && A[i][j - 1] <= element)
        {
            flows = Pacific(i, j - 1);
        }

        if (!flows && j + 1 < n && A[i][j + 1] <= element)
        {
            flows = Pacific(i, j + 1);
        }

        if (!flows && i + 1 < m && A[i + 1][j] <= element)
        {
            flows = Pacific(i + 1, j);
        }
        A[i][j] = element;
        return flows;
    }

    bool Atlantic(int i, int j)
    {
        if (i == m - 1 || j == n - 1) return true;
        if (A[i][j] == -1) return false;
        int element = A[i][j];
        A[i][j] = -1;
        bool flows = false;

        if (A[i + 1][j] <= element)
        {
            flows = Atlantic(i + 1, j);
        }
        if (!flows && A[i][j + 1] <= element)
        {
            flows = Atlantic(i, j + 1);
        }
        if (!flows && j - 1 >= 0 && A[i][j - 1] <= element)
        {
            flows = Atlantic(i, j - 1);
        }
        if (!flows && i - 1 >= 0 && A[i - 1][j] <= element)
        {
            flows = Atlantic(i - 1, j);
        }
        A[i][j] = element;
        return flows;
    }
}