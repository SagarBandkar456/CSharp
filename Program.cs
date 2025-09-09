using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        AdjacencyMatrix adjacencyMatrix = new();
        int v = 4;

        int[,] mat = new int[v, v];

        adjacencyMatrix.AddEdge(mat, 0, 1);
        adjacencyMatrix.AddEdge(mat, 0, 2);
        adjacencyMatrix.AddEdge(mat, 1, 2);
        adjacencyMatrix.AddEdge(mat, 2, 3);

        adjacencyMatrix.DisplayMatrix(mat);

        Console.ReadLine();
    }
}