using System;

public class LongSub3
{
    public int LengthOfLongestSubstring(string s)
    {
        int len = 0;
        int left = 0;
        int right = 0;
        int n = s.Length;
        Dictionary<char, int> dt = new();

        while (right < n)
        {
            if (dt.ContainsKey(s[right]))
                left = Math.Max(left, dt[s[right]] + 1);

            dt[s[right]] = right;
            len = Math.max(len, right - left + 1);
            right++;
        }

        return len;
    }
}