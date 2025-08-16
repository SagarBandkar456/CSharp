using System;

public class NumberOfSubString1358
{
    public int NumberOfSubstrings(string s)
    {
        int cnt = 0;
        int[] lastScan = { -1, -1, -1 };

        for (int i = 0; i < s.Length; i++)
        {
            lastScan[s[i] - 'a'] = i;

            if (lastScan[0] != -1 && lastScan[1] != -1 && lastScan[2] != -1)
            {
                cnt += 1 + Math.Min(lastScan[0], Math.Min(lastScan[1], lastScan[2]));
            }
        }

        return cnt;
    }
}