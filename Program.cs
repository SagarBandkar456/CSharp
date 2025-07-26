using System;
using System.Globalization;

public class Program
{
    static int[] nums = [3, 9, 6];
    static int k = 2;

    public static void Main(string[] args)
    {
        int[] arr = { 7, 1, 5, 3, 6, 4 };
        SellStock121 sellStock121 = new SellStock121();
        sellStock121.MaxProfit(arr);
        Console.ReadLine();
    }
}