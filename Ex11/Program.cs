using System;

/*
 * Write a method to check if an array contains a particular number.
 */
namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
				var result1 = Has(new int[] {1,2,3,4,5}, 3);
				var result2 = Has(new int[] {1,1,2,1,1}, 3);
				var result3 = Has(new int[] {5,5,5,6}, 5);
				var result4 = Has(new int[0], 5);

				Console.WriteLine($"{result1}\n{result2}\n{result3}\n{result4}");
        }

			static bool Has(int[] numbers, int match)
			{
				foreach (var n in numbers)
					if (n == match) return true;

				return false;
			}
    }
}
