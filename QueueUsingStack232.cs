using System;

public class QueueUsingStack232
{
    Stack<int> mn = new();
    Stack<int> temp = new();

    public void Push(int x)
    {
        while (mn.Count > 0) temp.Push(mn.Pop());
        mn.Push(x);
        while (temp.Count > 0) mn.Push(temp.Pop());
    }

    public int Pop() => mn.Pop();

    public int Peek() => mn.Peek();

    public bool Empty() => mn.Count == 0;
}