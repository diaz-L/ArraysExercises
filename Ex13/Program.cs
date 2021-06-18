using System;
using System.Resources;
using System.Runtime.InteropServices;

/*
 * Create a function that takes an array of numbers and returns a new array sorted in ascending order.
 * If an null is given return an empty array
 */
namespace Ex13
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr1 = { 1, 2, 10, 50, 5 },
            arr2 = { 80, 29, 4, -95, -24, 85 },
            arr3 = null,
            arr4 = new int[0];

      var results1 = SortNumbersAsc(arr1);
      PrintReport(arr1, results1);

      var results2 = SortNumbersAsc(arr2);
      PrintReport(arr2, results2);

      var results3 = SortNumbersAsc(arr3);
      PrintReport(arr3, results3);

      var results4 = SortNumbersAsc(arr4);
      PrintReport(arr4, results4);
    }

    static int[] SortNumbersAsc(int[] list)
    {
      if (list == null || list.Length == 0) return new int[0];

      int[] results = new int[list.Length];

      for (var i = 0; i < list.Length - 1; i++)
        for (var j = i + 1; j < list.Length; j++)
          if (list[j] < list[i])
            Swap(ref list[i], ref list[j]);

      return results;
    }

    static void Swap(ref int a, ref int b)
    {
      int tmp = a;
      a = b;
      b = tmp;
    }

    static void PrintReport(int[] list1, int[] list2)
    {
      Console.Write("Before: ");
      PrintList(list1);
      Console.Write("\tSorted: ");
      PrintList(list2);
      Console.WriteLine();
    }

    static void PrintList(int[] nums)
    {
      Console.Write("[ ");

      foreach (var n in nums ?? new int[0])
        Console.Write($"{n} ");

      Console.Write(" ]");

    }
  }
}
