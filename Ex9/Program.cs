using System;

/*
 * Create a functin that takes an array of values and returns the first and last values. 
 */
namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
		  {
				(int First, int Last) result1 = FirstLast(new int[] {5, 10, 15, 20, 25});
				(object First, object Last) result2 = FirstLast(new object[] {"edabit", 13, null, false, true});
				(object First, object Last) result3 = FirstLast(new object[] {false, 4, "6", "hello", null});

				PrintResults(result1.First, result1.Last);
				PrintResults(result2.First, result2.Last);
				PrintResults(result3.First, result3.Last);
        }

			static (T, T) FirstLast<T>(T[] list)
			{
				if (list.Length == 1) return (list[0], list[0]);

				return (list[0], list[list.Length - 1]);
			}

			static void PrintResults(object first, object second)
			{
				var value1 = first ?? "null";
				var value2 = second ?? "null";
				
				Console.WriteLine($"first: {value1} last: {value2}");
			}
    }
}
