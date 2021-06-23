using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Create a function that takes an array of numbers and returns only the even numbers
 */
namespace Ex15
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] list1 = { 1, 2, 3, 4, 5, 6, 7, 8 },
            list2 = { 43, 65, 23, 89, 53, 9, 6 },
            list3 = { 718, 991, 449, 644, 380, 440 };

      PrintFormatedOutput(list1);
      PrintFormatedOutput(list2);
      PrintFormatedOutput(list3);
    }

    static void PrintFormatedOutput(int[] list)
    {
      PrintArray(list);
      Console.Write(" -> ");
      PrintArray(NoOdds(list));
      Console.WriteLine();
    }

    static void PrintArray(int[] list)
    {
      Console.Write("[ ");
      foreach (var n in list)
        Console.Write($"{n} ");
      Console.Write("]");
    }

    static int[] NoOdds(int[] list)
    {
      List<int> results = new List<int>(list.Length);

      foreach (var n in list)
        if (IsEven(n)) results.Add(n);

      return results.ToArray();
    }

    static bool IsEven(int n)
    {
      return (n & 1) == 0;
    }

  }
}
