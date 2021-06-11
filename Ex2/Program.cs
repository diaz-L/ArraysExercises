using System;

/*
 * Give an array of integers, return the difference between the largest and smallest integers of the array
 */
namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
				int result1 = Diff(new int[] {10, 15, 20, 2, 10, 6});	//18
				int result2 = Diff(new int[] {-3, 4, -9, -1, -2, 15});	//24
				int result3 = Diff(new int[] {4, 17, 12, 2, 10, 2});	//15

				Console.WriteLine($"{result1}\n{result2}\n{result3}");
        }

			static int Diff(int[] list)
			{
				int max = Max(list);
				int min = Min(list);
				return max - min;
			}

			static int Max(int[] numbers)
			{
				int max = Int32.MinValue;
				foreach (var n in numbers)
					if (n > max) max = n;

				return max;
			}
			
			static int Min(int[] numbers)
			{
				int min = Int32.MaxValue;
				foreach (var n in numbers)
					if (n < min) min = n;

				return min;
			}
    }
}
