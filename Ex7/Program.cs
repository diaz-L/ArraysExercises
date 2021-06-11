using System;

/*
 * Create a function that takes an array of numbers and returns the smallest number in the set
 */
namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
				Console.WriteLine( FindSmallestNumber(new int[] {34, 15, 88, 2}) );
				Console.WriteLine( FindSmallestNumber(new int[] {34, -345, -1, 100}) );
				Console.WriteLine( FindSmallestNumber(new int[] {-76, 145, 1, 0}) );
				Console.WriteLine( FindSmallestNumber(new int[] {7, 7, 7}) );
        }

			static int FindSmallestNumber(int[] numbers)
			{
				int min = Int32.MaxValue;
			
				foreach (var n in numbers)
					if (n < min) min = n;

				return min;
			}
    }
}
