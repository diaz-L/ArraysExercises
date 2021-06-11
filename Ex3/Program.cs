using System;

/*
 * Create a function that accepts an array and returns the last item in the array. The array can contain any of C#'s
 * primitive data types
 */
namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
				int[] numbers = { 11, 7, 5, 2, 27 };
				string[] cars = { "bmw", "volvo", "subaru", "mazda" };

				string lastCar = LastOf(cars);
				int lastNumber = LastOf(numbers);

				Console.WriteLine($"car: {lastCar}\nnumber: {lastNumber}");
        }

			static T LastOf<T>(T[] list)
			{
				return list.Length == 0 
								? default(T) 
								: list[list.Length - 1];
			}
    }
}
