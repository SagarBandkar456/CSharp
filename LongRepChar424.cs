using System;

public class LongRepChar424
{
    public int CharacterReplacement(string s, int k)
    {
        int left = 0, right = 1;
        int n = s.Length;
        int res = 0;
        int freq = 0;
        Dictionary<char, int> dt = new();

        while (right < n)
        {
            if (dt.ContainsKey(s[i])) dt[s[i]]++;
            else dt.Add(s[i], i);

            if (freq <= dt[s[i]]) freq = dt[s[i]];

            while (right - freq > k)
            {
                dt[s[i]]--;
                left++;
            }

            res = Math.Max(res, right - left + 1);
            right++;
        }

        return res;
    }
}