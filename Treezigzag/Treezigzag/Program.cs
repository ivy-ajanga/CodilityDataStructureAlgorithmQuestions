using System;

class Solution
{
    int Checker(Tree T, int max, bool left, bool right)
    {
        int l = 0;
        int r = 0;
        while (left)
        {
            if (T.l != null)
            {
                T = T.l;
                l++;
            }
            else
                break;
            if (T.r != null)
            {
                T = T.r;
                l++;
            }
            else
                break;

        }
        max = Math.Max(l, max);
        while (right)
        {
            if (T.r != null)
            {
                T = T.r;
                r++;
            }
            else
                break;
            if (T.l != null)
            {
                T = T.l;
                r++;
            }
            else
                break;

        }
        max = Math.Max(r, max);
        max = Checker(T.r, max, false, true);
        max = Checker(T.l, max, true, false);
        return max;
    }
    public int solution(Tree T)
    {
        if (T == null) return 0;
        return Checker(T, 0, true, true);
    }
}
