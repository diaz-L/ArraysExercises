using System;

/*
 * Create a function that adds a string ending to each member in an array
 */
namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
				var array1 = new string[] {"clever", "meek", "hurried", "nice"};
				var array2 = new string[] {"new", "pander", "scoop"};
				var array3 = new string[] {"bend", "sharpen", "mean"};
	
				var results1 = AddEnding(array1, "ly");
				var results2 = AddEnding(array2, "er");
				var results3 = AddEnding(array3, "ing");

				PrintResults(array1, results1);
				PrintResults(array2, results2);
				PrintResults(array3, results3);
        }

		  static string[] AddEnding(string[] list, string ending)
		  {
				var endings = new string[list.Length];

				for (var i = 0; i < list.Length; i++)
				{
					endings[i] = $"{list[i]}{ending}";
				}

				return endings;
		  }

		  static void ArrayToString(string[] list)
		  {
				Console.Write("[ ");
				foreach (var item in list)
					Console.Write($"{item} ");
				Console.WriteLine("]");
		  }

			static void PrintResults(string[] arr1, string[] arr2)
			{
				Console.Write("Before:\t");
				ArrayToString(arr1);
				Console.Write("After:\t");
				ArrayToString(arr2);
				Console.WriteLine();
			}
    }
}
