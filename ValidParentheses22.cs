using System;
using System.Collections;

public class ValidParentheses22
{
    public bool IsValid(string s)
    {
        Stack<char> st = new();
        char[] input = s.ToCharArray();

        if (s.Length <= 1) return false;
        foreach (char c in input)
        {
            if (c == '(' || c == '{' || c == '[') st.Push(c);

            if (st.Count() <= 0) return false;
            if ((c == ')' && st.Peek() != '(') ||
                (c == '}' && st.Peek() != '{') ||
                (c == ']' && st.Peek() != '['))
            {
                return false;
            }
            st.Pop();


        }

        return true;
    }
}