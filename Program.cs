using System;
using System.Globalization;

public class Program
{
    static int[] nums = [3, 9, 6];
    static int k = 2;

    public static void Main(string[] args)
    {
        int[] arr = { 0, 1, 0, 3, 12 };
        MoveZeros283 moveZeros283 = new MoveZeros283();
        moveZeros283.MoveZeroes(arr);
        Console.ReadLine();
    }
}