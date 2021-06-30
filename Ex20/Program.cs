using System;
using System.Linq;

/*
 * create a function that determines whether elements in an array can be re-arranged to form a 
 * consecutive list of numbers where each number appears exactly once.
 */
namespace Ex20
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintCheckOfConsecutiveList(new int[] { 5, 1, 4, 3, 2 });
      PrintCheckOfConsecutiveList(new int[] { 5, 1, 4, 3, 2, 8 });
      PrintCheckOfConsecutiveList(new int[] { 5, 6, 7, 8, 9, 9 });
      PrintCheckOfConsecutiveList(new int[] { 5, 3 });
      PrintCheckOfConsecutiveList(new int[] { -3, -2, -1, 1, 0 });
    }

    static void PrintCheckOfConsecutiveList(int[] nums)
    {
      if (nums is null)
        throw new ArgumentNullException();

      PrintList(nums);
      Console.WriteLine($" -> is_consecutive: {IsConsecutive(nums)}");
    }

    static void PrintList<T>(T[] list)
    {
      if (list is null)
        throw new ArgumentNullException();

      Console.Write("[ ");
      foreach (var item in list)
        Console.Write($"{item} ");
      Console.Write("]");
    }

    static bool IsConsecutive(int[] nums)
    {
      int min = Min(nums);

      int[] consecutiveArr = Enumerable.Range(min, nums.Length).ToArray();
      Array.Sort(nums);

      return consecutiveArr.SequenceEqual(nums);
    }

    static int Min(int[] nums)
    {
      if (nums is null)
        throw new ArgumentNullException();

      int min = Int32.MaxValue;

      foreach (var n in nums)
        if (n < min) min = n;

      return min;
    }

    // static int Max(int[] nums)
    // {
    //   if (nums is null)
    //     throw new ArgumentNullException();

    //   int max = Int32.MinValue;

    //   foreach (var n in nums)
    //     if (n > max) max = n;

    //   return max;
    // }
  }
}
