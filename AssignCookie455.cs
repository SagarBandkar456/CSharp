using System;
using System.Globalization;

public class AssignCookie455
{
    public int FindContentChildren(int[] g, int[] s)
    {
        int res = 0;
        Array.Sort(g);
        Array.Sort(s);

        int i = 0;
        int j = 0;
        while (i < s.Length && j < g.Length)
        {
            if (s[i] >= g[j])
            {
                res++;
                i++;
            }
            else
            {
                j++;
            }
        }

        return res;
    }
}