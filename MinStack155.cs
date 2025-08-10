using System;

public class MinStack155
{
    Stack<int> st;
    Stack<int> min;

    public MinStack155()
    {
        st = new();
        min = new();
    }

    public void Push(int val)
    {
        st.Push(val);

        if (min.Count == 0 || val <= min.Peek())
        {
            min.Push(val);
        }
    }

    public void Pop()
    {
        if (st.Count == 0) return;

        if (min.Count > 0 && st.Peek() == min.Peek())
            min.Pop();

        st.Pop();
    }

    public int Top()
    {
        if (st.Count <= 0) return 0;
        return st.Peek();
    }

    public int GetMin()
    {
        if (min.Count <= 0) return 0;
        return min.Peek();
    }
}