using System;

/*
 * Create a function to multiply all of the values in an array by the amount of values in the given array.
 */
namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
				int[] arr1 = {2,3,1,0}, 
						arr2 = {4,1,1}, 
						arr3 = {1,0,3,3,7,2,1},
						arr4 = {0},
						arr5 = new int[0];
					
				PrintReport(arr1, arr2, arr3, arr4, arr5);
        }

			static int[] MultiplyByLength(int[] nums)
			{
				int[] results = new int[nums.Length];
	
				for(var i = 0; i < nums.Length; i++)
					results[i] = nums[i] * nums.Length;

				return results;
			}

			static void PrintReport(params int[][] list)
			{

				foreach (var arr in list) {
					Console.Write("Before: ");
					PrintList(arr);
					var results = MultiplyByLength(arr);
					Console.Write("\tAfter: ");
					PrintList(results);
					Console.WriteLine();
				}
			}

			static void PrintList<T>(T[] list)
			{
				Console.Write("[ ");
				foreach (var item in list)
					Console.Write($"{item} ");
				Console.Write("]");
			}
    }
}
