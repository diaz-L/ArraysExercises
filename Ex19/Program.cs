using System;

/*
 * create a function that takes a list of numbers and returns the sum of all prime numbers in the list.
 */
namespace Ex19
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintSumOfPrimes(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
      PrintSumOfPrimes(new int[] { 2, 3, 4, 11, 20, 50, 71 });
      PrintSumOfPrimes(new int[] { });
      PrintSumOfPrimes(new int[] { 67, 24, 58, 28, 71, 73, 99 });
    }

    static void PrintSumOfPrimes(int[] list)
    {
      PrintList(list);
      Console.WriteLine($" -> sum_Of_primes: {SumOfPrimes(list)}");
    }

    static void PrintList<T>(T[] list)
    {
      if (list == null)
      {
        Console.Write("[ ]");
        return;
      };

      Console.Write("[ ");
      foreach (var item in list)
        Console.Write($"{item} ");
      Console.Write("]");
    }

    static int SumOfPrimes(int[] list)
    {
      //does not check for `null reference` list

      int totalSum = 0;

      foreach (var num in list)
        if (IsPrime(num))
          totalSum += num;

      return totalSum;
    }

    static bool IsPrime(int num)
    {
      if (num <= 1) return false;
      if (num == 2) return true;

      int limit = (int)Math.Ceiling(Math.Sqrt(num));

      for (int i = 2; i <= limit; i++)
        if (IsEven(num) || IsMultipleOf(num, i)) return false;

      return true;
    }

    static bool IsEven(int n)
    {
      return (n & 1) == 0;
    }

    static bool IsMultipleOf(int num, int factor)
    {
      return (num % factor) == 0;
    }
  }
}
