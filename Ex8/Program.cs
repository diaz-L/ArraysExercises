using System;

/*
 * Create a function that takes an array of numbers, and returns the largest number in the array.
 */
namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLargestNumber(new int[] {4, 5, 1, 3}));
				Console.WriteLine(FindLargestNumber(new int[] {300, 200, 600, 150}));
				Console.WriteLine(FindLargestNumber(new int[] {1_000, 1_001, 857, 1}));
        }

			static int FindLargestNumber(int[] numbers)
			{
				int max = Int32.MinValue;

				foreach (var n in numbers)
					if (n > max) max = n;

				return max;
			}
    }
}
