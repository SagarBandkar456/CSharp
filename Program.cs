using System;
using System.Globalization;

public class Program
{
    static int[] nums = [3, 9, 6];
    static int k = 2;

    public static void Main(string[] args)
    {
        int[] arr = { 7, 3, 5, 1, 9, 4 };
        QuickSort quickSort = new QuickSort();
        quickSort.Sort(arr, 0, arr.Length - 1);
        quickSort.Print(arr, arr.Length);
        Console.ReadLine();

    }
}