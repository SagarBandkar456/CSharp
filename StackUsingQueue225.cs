using System;

public class StackUsingQueue225
{
    public Queue<int> q = new Queue<int>();

    public StackUsingQueue225()
    {
        q = new();
    }

    public void Push(int x)
    {
        q.Enqueue(x);

        for (int i = 0; i < q.Count() - 1; i++)
        {
            q.Enqueue(q.Dequeue());
        }
    }

    public int Pop()
    {
        return q.Dequeue();
    }

    public int Top()
    {
        return q.Peek();
    }

    public bool Empty()
    {
        return q.Count() == 0;
    }
}