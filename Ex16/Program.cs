using System;

/*
 * create a function that takes an array of numbers and returns an array where each number is the sum of 
 * itself + all previous numbers in the array.
 */
namespace Ex16
{
  class Program
  {
    static void Main(string[] args)
    {
      var list1 = new int[] { 1, 2, 3 };
      var list2 = new int[] { 1, -2, 3 };
      var list3 = new int[] { 3, 3, -2, 408, 3, 3 };

      PrintCumulativeSum(list1);
      PrintCumulativeSum(list2);
      PrintCumulativeSum(list3);
    }

    static void PrintCumulativeSum(int[] nums)
    {
      PrintList(nums);
      Console.Write(" -> ");
      var results = CumulativeSum(nums);
      PrintList(results);
      Console.WriteLine();
    }

    static void PrintList<T>(T[] list)
    {
      Console.Write("[ ");
      foreach (var item in list)
        Console.Write($"{item} ");
      Console.Write("]");
    }

    static int[] CumulativeSum(int[] nums)
    {
      var results = new int[nums.Length];

      for (int i = 0, sum = 0; i < nums.Length; i++)
      {
        sum += nums[i];
        results[i] = sum;
      }

      return results;
    }
  }
}
