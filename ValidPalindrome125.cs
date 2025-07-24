using System;

public class ValidPalindrome125
{
    public bool IsPalindrome(string str)
    {
        bool res = true;
        int start = 0;
        int end = str.Length - 1;

        while (start <= end)
        {
            char cStart = str[start];
            char cEnd = str[end];
            if (!char.IsLetter(cStart) && !char.IsDigit(cStart))
            {
                start++;
            }
            else if (!char.IsLetter(cEnd) && !char.IsDigit(cEnd))
            {
                end--;
            }
            else if (char.ToLower(cStart).Equals(char.ToLower(cEnd)))
            {
                start++;
                end--;
            }
            else
            {
                res = false;
                break;
            }
        }

        return res;
    }
}