using System;

public class ValidString678
{
    public bool CheckValidString(string s)
    {
        int low = 0, high = 0;

        foreach (char ch in s)
        {
            if (ch == '(')
            {
                low++;
                high++;
            }
            else if (ch == ')')
            {
                if (low > 0) low--;   // use one '('
                high--;
            }
            else // '*'
            {
                if (low > 0) low--;   // treat '*' as ')'
                high++;               // or treat '*' as '('
            }

            if (high < 0) return false; // too many ')'
        }

        return low == 0; // all '(' matched
    }
}