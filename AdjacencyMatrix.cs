using System;

public class AdjacencyMatrix
{

    public void AddEdge(int[,] mat, int i, int j)
    {
        mat[i, j] = 1;
        mat[j, i] = 1;
    }


    public void DisplayMatrix(int[,] mat)
    {
        int v = mat.GetLength(0);

        for (int i = 0; i < v; i++)
        {
            for (int j = 0; j < v; j++)
            {
                System.Console.Write(mat[i, j] + " ");
            }

            System.Console.WriteLine();
        }
    }
}