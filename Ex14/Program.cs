using System;

/*
 * Create a function that takes a number (1 to 12) and returns its correspoding month name as a string.
 */
namespace Ex14
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(MonthName(3));
      Console.WriteLine(MonthName(12));
      Console.WriteLine(MonthName(6));
    }

    static string MonthName(int n)
    {
      string[] months = {
                "January", "February", "March", "April",
                "May", "June", "July", "August", "September",
                "October", "November", "December"
            };

      return n < 1 || n > 12 ? "Unknown" : months[n - 1];
    }
  }
}
