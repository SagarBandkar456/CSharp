using System;

public class MergeSort
{
    public void Sort(int[] arr)
    {
        int len = arr.Length;
        if (len <= 1) return;
        int mid = len / 2;

        int[] leftArr = new int[mid];
        int[] rightArr = new int[len - mid];

        int i = 0;
        int j = 0;

        for (; i < len; i++)
        {
            if (i < mid)
                leftArr[i] = arr[i];
            else
            {
                rightArr[j] = arr[i];
                j++;
            }
        }

        Sort(leftArr);
        Sort(rightArr);
        Merge(arr, leftArr, rightArr);

    }

    public void Merge(int[] arr, int[] leftArr, int[] rightArr)
    {
        int leftSize = arr.Length / 2;
        int rightSize = arr.Length - leftSize;
        int i = 0, l = 0, r = 0;

        while (l < leftSize && r < rightSize)
        {
            if (leftArr[l] < rightArr[r])
            {
                arr[i] = leftArr[l];
                i++;
                l++;
            }
            else
            {
                arr[i] = rightArr[r];
                i++;
                r++;
            }
        }

        while (l < leftSize)
        {
            arr[i] = leftArr[l];
            i++;
            l++;
        }

        while (r < rightSize)
        {
            arr[i] = rightArr[r];
            i++;
            r++;
        }
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