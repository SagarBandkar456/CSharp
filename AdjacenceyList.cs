using System;

public class AdjacenceyList
{
    public static void AddEdge(List<List<int>> ls, int i, int j)
    {
        ls[i].Add(j);
        ls[j].Add(i);
    }

    public static void Print(List<List<int>> ls)
    {
        for (int i = 0; i < ls.Count; i++)
        {
            Console.Write(i + ": ");
            foreach (var data in ls[i])
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        int v = 4;
        List<List<int>> adj = new List<List<int>>(v);
        for (int i = 0; i < v; i++)
            adj.Add(new List<int>());

        AddEdge(adj, 0, 1);
        AddEdge(adj, 0, 2);
        AddEdge(adj, 1, 2);
        AddEdge(adj, 2, 3);

        Print(adj);
    }
}