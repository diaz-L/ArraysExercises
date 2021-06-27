using System;

/*
 * create a function that takes two numbers as arguments (num, length) and returns an array of multiples of 
 * num until the array length reaches length.
 */
namespace Ex17
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintArrayOfMultiplesFor(7, 5);
      PrintArrayOfMultiplesFor(12, 10);
      PrintArrayOfMultiplesFor(17, 6);
      PrintArrayOfMultiplesFor(0, 3);
      PrintArrayOfMultiplesFor(2, 0);
    }

    static void PrintArrayOfMultiplesFor(int num, int length)
    {
      Console.Write($"({num}, {length}) -> ");
      var arrOfMultiples = ArrayOfMultiples(num, length);
      PrintList(arrOfMultiples);
      Console.WriteLine();
    }

    static void PrintList<T>(T[] list)
    {
      Console.Write("[ ");
      foreach (var item in list)
        Console.Write($"{item} ");
      Console.Write("]");
    }

    static int[] ArrayOfMultiples(int num, int length)
    {
      var results = new int[length];

      for (int i = 1; i <= length; i++)
        results[i - 1] = num * i;

      return results;
    }
  }
}
