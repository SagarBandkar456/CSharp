using System;

public class QuickSort
{
    public void Sort(int[] arr, int start, int end)
    {
        if (end <= start) return;

        int pivot = Partition(arr, start, end);
        Sort(arr, start, pivot - 1);
        Sort(arr, pivot + 1, end);
    }

    public int Partition(int[] arr, int start, int end)
    {
        int pivot = arr[end];
        int i = start - 1;

        for (int j = start; j < end; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int tem = arr[i];
                arr[i] = arr[j];
                arr[j] = tem;
            }
        }

        i++;
        int temp = arr[end];
        arr[end] = arr[i];
        arr[i] = temp;

        return i;
    }

    public void Print(int[] arr, int len)
    {
        for (int i = 0; i < len; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}