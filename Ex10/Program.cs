using System;

/*
 * Create a function that takes in an array of numbers and returns the sum of its cubes.
 */
namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
				Console.WriteLine(SumOfCubes(new int[] {1, 5, 9}));	
				Console.WriteLine(SumOfCubes(new int[] {3, 4, 5}));	
				Console.WriteLine(SumOfCubes(new int[] {2}));	
        }

		 static int SumOfCubes(int[] numbers)
		 {
				int sum = 0;

				foreach (var n in numbers)
					sum += (int) Math.Pow(n, 3);

				return sum;
		 }
    }
}
