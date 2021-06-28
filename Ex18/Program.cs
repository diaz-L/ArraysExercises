using System;
using System.Security.Cryptography;

/*
 * Create a function that takes an array of names and returns an array where only the first letter of 
 * each name is capitalized.
 */
namespace Ex18
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] s1 = new string[] { "mavis", "senaida", "letty" },
               s2 = new string[] { "samuel", "MABELLE", "letitia", "meridith" },
               s3 = new string[] { "Slyvia", "Kristal", "Sharilyn", "Calista" },
               s4 = new string[0];

      PrintListCapitalize(s1);
      PrintListCapitalize(s2);
      PrintListCapitalize(s3);
      PrintListCapitalize(s4);

      try
      {
        PrintListCapitalize(null);
      }
      catch (Exception)
      {
        Console.WriteLine("expected null exception caught");
      }
    }

    static void PrintListCapitalize(string[] list)
    {
      PrintList(list);
      Console.Write(" -> ");
      var capList = Capitalize(list);
      PrintList(capList);
      Console.WriteLine();
    }

    static void PrintList<T>(T[] list)
    {
      if (list == null)
      {
        Console.Write("null");
        return;
      }

      Console.Write("[ ");

      foreach (var item in list)
        Console.Write($"{item} ");

      Console.Write("]");
    }

    static string[] Capitalize(string[] list)
    {
      if (list == null)
        throw new ArgumentException("expecting array of strings");

      var results = new string[list.Length];

      for (int i = 0; i < list.Length; i++)
        if (string.IsNullOrEmpty(list[i]))
          results[i] = list[i];
        else
          results[i] = char.ToUpper(list[i][0]) + list[i].Substring(1).ToLower();

      return results;
    }
  }
}
