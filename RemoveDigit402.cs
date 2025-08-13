using System;
using System.Globalization;
using System.Text;

public class RemoveDigit402
{
    public string RemoveKdigits(string num, int k)
    {
        Stack<char> st = new();
        if (k == num.Length) return "0";

        for (int i = 0; i < num.Length; i++)
        {
            char digit = num[i];
            while (st.Count > 0 && k > 0 && st.Peek() > digit)
            {
                st.Pop();
                k--;
            }
            st.Push(num[i]);
        }

        while (k > 0)
        {
            st.Pop();
            k--;
        }

        StringBuilder sb = new StringBuilder();
        while (st.Count > 0)
        {
            sb.Insert(0, st.Pop());
        }
        string result = sb.ToString().TrimStart('0');

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}