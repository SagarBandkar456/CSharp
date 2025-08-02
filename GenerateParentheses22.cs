using System;
using System.Text;

public class GenerateParentheses22
{
    List<string> res = new();
    public IList<string> GenerateParenthesis(int n)
    {
        StringBuilder curr = new();
        int open = 0;
        int close = 0;

        solve(open, close, curr, n);
        return res;
    }

    public void solve(int open, int close, StringBuilder curr, int n)
    {
        if (curr.Length == 2 * n)
        {
            res.Add(curr.ToString());
            return;
        }

        if (open < n)
        {
            curr = curr.Append("(");
            solve(open + 1, close, curr, n);
            curr.Remove(curr.Length - 1, 1);
        }

        if (close < open)
        {
            curr = curr.Append(")");
            solve(open, close + 1, curr, n);
            curr.Remove(curr.Length - 1, 1);
        }
    }
}